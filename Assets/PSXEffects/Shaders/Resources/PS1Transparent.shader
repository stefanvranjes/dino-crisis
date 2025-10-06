Shader "PSXEffects/PS1Transparent"
{
	Properties
	{
		_OffsetFactor("Offset factor", Float) = 1.0
		_OffsetUnits("Offset units", Float) = 1.0
		_Color("Color", Color) = (1,1,1,1)
		_MainTex("Texture", 2D) = "white" {}
		_Tex8("Texture 8", 2D) = "white" {}
		_CLUT("CLUT Texture", 2D) = "white" {}
		_LODTex("LOD Texture", 2D) = "white" {}
		_LODAmt("LOD Amount", Float) = 0.0

		[HideInInspector] _SrcBlend("__src", Float) = 1.0
		[HideInInspector] _DstBlend("__dst", Float) = 0.0
		[HideInInspector] _ZWrite("__zw", Float) = 1.0
		[HideInInspector] _Cul("__cul", Float) = 0.0
		[HideInInspector] _BlendOp("__bld", Float) = 0.0

		[HideInInspector] _RenderMode("__rnd", Float) = 1
	}

	SubShader
	{
		Tags { "Queue" = "Transparent" "RenderType" = "Opaque" }
		LOD 100
		Lighting Off
		Cull Off
		Blend[_SrcBlend][_DstBlend]
		BlendOp[_BlendOp]
		ZTest LEqual
		ZWrite Off

		Pass
		{
			Tags { "LightMode" = "ForwardBase" }
			CGPROGRAM
			
			#include "UnityCG.cginc"
			#include "PSXEffects.cginc"

			#pragma vertex vert
			#pragma fragment frag
			#pragma multi_compile_fog

			struct appdata {
				float4 vertex : POSITION;
				float4 uv_MainTex : TEXCOORD0;
				float4 color : COLOR;
				float4 uv2_MainTex : TEXCOORD1;
			};

			struct v2f
			{
				float4 uv_MainTex : TEXCOORD0;
				fixed4 color : COLOR;
				float4 pos : SV_POSITION;

				UNITY_FOG_COORDS(10)
				float4 uv2_MainTex : TEXCOORD11;
			};

			v2f vert(appdata v)
			{
				v2f o;
				UNITY_INITIALIZE_OUTPUT(v2f, o);

				// Vertex inaccuracy block
				o.pos = UnityObjectToClipPos(v.vertex);
				float4 worldPos = mul(unity_ObjectToWorld, v.vertex);

				// Set UV outputs
				o.uv_MainTex = float4(v.uv_MainTex.xyz, 0);
				o.uv2_MainTex = float4(v.uv2_MainTex.xyz, 0);	

				// Set value for LOD distance
				o.uv_MainTex.a = (distance(worldPos, _WorldSpaceCameraPos) > _LODAmt && _LODAmt > 0);

				// Various outputs needed for fragment
				o.color = v.color;

				UNITY_TRANSFER_FOG(o, o.pos);

				return o;
			}

			fixed4 frag(v2f i) : SV_Target
			{
				float4 albedo = tex2D(_MainTex, i.uv_MainTex);

				if (i.uv2_MainTex.z == 1)
					albedo = tex2D(_Tex8, i.uv_MainTex);

				albedo = tex2D(_CLUT, float2(albedo.r + i.uv2_MainTex.x, i.uv2_MainTex.y));
				float4 col = albedo;

				#if !UNITY_COLORSPACE_GAMMA
					albedo.rgb = LinearToGammaSpace(albedo.rgb);
				#endif
				
				// If material is unlit, just set color to albedo
				col.rgb = albedo;
				// Tint material

				if (_ColorIntensity)
					col *= i.color * _Color * 2;
				else
					col *= i.color * _Color;

				col.a = albedo.a * i.color.a * _Color.a;

				if (_RenderMode == 2.0 && albedo.a == 0) {
					// Don't draw if outside render distance
					discard;
				}

				col.rgb = saturate(col.rgb);

				#if !UNITY_COLORSPACE_GAMMA
					col.rgb = GammaToLinearSpace(col.rgb * 1.1);
				#endif

				UNITY_APPLY_FOG(i.fogCoord, col.rgb);

				return col;
			}
			ENDCG
		}
	}
	CustomEditor "PS1ShaderEditor"
}
