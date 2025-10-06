// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

Shader "PSXEffects/PS1Billboard"
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

		[HideInInspector] _RenderMode("__rnd", Float) = 0.0
	}

	SubShader
	{
		Tags { "Queue" = "Geometry" "RenderType" = "Opaque" }
		LOD 100
		Lighting On
		Offset[_Offset], 1
		Cull Off
		Blend[_SrcBlend][_DstBlend]
		BlendOp[_BlendOp]
		ZWrite[_ZWrite]

		Pass
		{
			CGPROGRAM

            #pragma vertex vert
            #pragma fragment frag
            #pragma target 2.0
            #pragma multi_compile_fog

            #include "UnityCG.cginc"
			#include "PSXEffects.cginc"

            struct appdata_t {
                float4 vertex : POSITION;
                float4 uv_MainTex : TEXCOORD0;
				float4 color : COLOR;
				float4 uv2_MainTex : TEXCOORD1;
                UNITY_VERTEX_INPUT_INSTANCE_ID
            };

            struct v2f {
                float4 vertex : SV_POSITION;
                float4 uv_MainTex : TEXCOORD0;
				fixed4 color : COLOR;
				float4 uv2_MainTex : TEXCOORD11;
                UNITY_FOG_COORDS(1)
                UNITY_VERTEX_OUTPUT_STEREO
            };

            v2f vert (appdata_t v)
            {
                v2f o;
                UNITY_SETUP_INSTANCE_ID(v);
                UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o);

				float scaleX = length(float4(UNITY_MATRIX_M[0].r, UNITY_MATRIX_M[1].r, UNITY_MATRIX_M[2].r, UNITY_MATRIX_M[3].r));
				float scaleY = length(float4(UNITY_MATRIX_M[0].g, UNITY_MATRIX_M[1].g, UNITY_MATRIX_M[2].g, UNITY_MATRIX_M[3].g));

				float3 vpos = mul((float3x3)unity_ObjectToWorld, v.vertex.xyz);

				o.vertex = mul(UNITY_MATRIX_P,
					mul(UNITY_MATRIX_MV, float4(0.0, 0.0, 0.0, 1.0))
					+ float4(vpos.x, vpos.y, 0.0, 0.0)
					* float4(1, 1, 1.0, 1.0));
                //o.vertex = UnityObjectToClipPos(o.vertex);
				float2 texcoord = TRANSFORM_TEX(v.uv_MainTex, _MainTex);
                o.uv_MainTex = float4(texcoord.xy, v.uv_MainTex.z, 0);
				o.uv2_MainTex = float4(v.uv2_MainTex.xyz, 0);
				o.color = v.color;
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                fixed4 col = tex2D(_MainTex, i.uv_MainTex);

				if (i.uv2_MainTex.z == 1)
					col = tex2D(_Tex8, i.uv_MainTex);

				col = tex2D(_CLUT, float2(col.r + i.uv2_MainTex.x, i.uv2_MainTex.y));
				i.color.a = 1;
				//col *= i.color;
				col *= 2;

				if (col.a == 0) {
					// Don't draw if outside render distance
					discard;
				}

				col.rgb = saturate(col.rgb);

#if !UNITY_COLORSPACE_GAMMA
				col.rgb = GammaToLinearSpace(col.rgb * 1.1);
#endif
                //UNITY_APPLY_FOG(i.fogCoord, col);
                return col;
            }
			ENDCG
		}
	}
	CustomEditor "PS1ShaderEditor"

}
