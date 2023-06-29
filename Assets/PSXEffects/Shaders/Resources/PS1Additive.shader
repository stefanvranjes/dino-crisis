Shader "PSXEffects/PS1Additive"
{
	Properties
	{
		[Toggle] _ColorOnly("Color Only", Float) = 0.0
		[Toggle] _Unlit("Unlit", Float) = 0.0
		[Toggle] _DrawDist("Affected by Polygonal Draw Distance", Float) = 1.0
		_VertexInaccuracy("Vertex Inaccuracy Override", Float) = -1.0
		_OffsetFactor("Offset factor", Float) = 1.0
		_OffsetUnits("Offset units", Float) = 1.0
		_Color("Color", Color) = (1,1,1,1)
		[KeywordEnum(Vertex, Fragment)] _DiffModel("Diffuse Model", Float) = 0.0
		_MainTex("Texture", 2D) = "white" {}
		_Tex8("Texture 8", 2D) = "white" {}
		_CLUT("CLUT Texture", 2D) = "white" {}
		_LODTex("LOD Texture", 2D) = "white" {}
		_LODAmt("LOD Amount", Float) = 0.0
		_NormalMap("Normal Map", 2D) = "bump" {}
		_NormalMapDepth("Normal Map Depth", Float) = 1
		[KeywordEnum(Gouraud, Phong)] _SpecModel("Specular Model", Float) = 0.0
		_SpecularMap("Specular Map", 2D) = "white" {}
		_Specular("Specular Amount", Float) = 0.0
		_MetalMap("Metal Map", 2D) = "white" {}
		_Metallic("Metallic Amount", Range(0.0,1.0)) = 0.0
		_Smoothness("Smoothness Amount", Range(0.0,1.0)) = 0.5
		_Emission("Emission Map", 2D) = "white" {}
		_EmissionAmt("Emission Amount", Float) = 0.0
		_Cube("Cubemap", Cube) = "" {}

		[HideInInspector] _SrcBlend("__src", Float) = 1.0
		[HideInInspector] _DstBlend("__dst", Float) = 0.0
		[HideInInspector] _ZWrite("__zw", Float) = 1.0
		[HideInInspector] _Cul("__cul", Float) = 0.0
		[HideInInspector] _BlendOp("__bld", Float) = 0.0

		[HideInInspector] _RenderMode("__rnd", Float) = 0.0
	}

	SubShader
	{
		Tags { "Queue"="Overlay" "DisableBatching" = "True" }
		LOD 100
		Offset -2, -2
		Blend One One // additive blending for a simple "glow" effect
		Cull Off // render backfaces as well
		ZWrite[_ZWrite] // don't write into the Z-buffer, this effect shouldn't block objects

		Pass
		{
			//Blend One One
			//SetTexture[_MainTex]{ combine texture }
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

				if (_VertexInaccuracy < 0) _VertexInaccuracy = _VertexSnappingDetail;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.vertex = PixelSnap(o.vertex);
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

				if (i.uv_MainTex.z == 1)
					col = tex2D(_Tex8, i.uv_MainTex);

				col = tex2D(_CLUT, float2(col.r + i.uv2_MainTex.x, i.uv2_MainTex.y));
				i.color.a = 1;
				col *= i.color;
				col *= 2;
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
