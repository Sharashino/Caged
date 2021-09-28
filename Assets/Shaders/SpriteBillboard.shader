Shader "Custom/TextureColorTransparent" {
    Properties{
        _MainTex("Base (RGB) Trans (A)", 2D) = "white" {}
        _Color("Main Color", Color) = (1,1,1,1)
        _ScaleX("ScaleX", Float) = 1
        _ScaleY("ScaleY", Float) = 1
    }

        SubShader{
            Tags {"Queue" = "Transparent" "IgnoreProjector" = "True" "RenderType" = "Transparent"}
            LOD 100

            ZWrite Off
            Blend SrcAlpha OneMinusSrcAlpha
            //Cull off

            Pass {
                CGPROGRAM
                    #pragma vertex vert
                    #pragma fragment frag
                    #pragma target 2.0
                    #pragma multi_compile_instancing
                    #pragma multi_compile_fog

                    #include "UnityCG.cginc"

                    struct appdata_t {
                        float4 vertex : POSITION;
                        float2 texcoord : TEXCOORD0;
                        UNITY_VERTEX_INPUT_INSTANCE_ID
                    };

                    struct v2f {
                        float4 vertex : SV_POSITION;
                        float2 texcoord : TEXCOORD0;
                        UNITY_FOG_COORDS(1)
                        UNITY_VERTEX_INPUT_INSTANCE_ID
                    };

                    UNITY_INSTANCING_BUFFER_START(Props)
                        UNITY_DEFINE_INSTANCED_PROP(fixed4, _Color)
                    UNITY_INSTANCING_BUFFER_END(Props)
                    sampler2D _MainTex;
                    float4 _MainTex_ST;

                    float _ScaleX;
                    float _ScaleY;

                    half3 ObjectScale() {
                        return half3(
                            length(unity_ObjectToWorld._m00_m10_m20),
                            length(unity_ObjectToWorld._m01_m11_m21),
                            length(unity_ObjectToWorld._m02_m12_m22)
                        );
                    }

                    v2f vert(appdata_t v)
                    {
                        v2f o;
                        UNITY_SETUP_INSTANCE_ID(v);
                        UNITY_TRANSFER_INSTANCE_ID(v, o);

                        half3 scale = ObjectScale();

                        o.vertex = mul(
                            UNITY_MATRIX_P, mul(
                                UNITY_MATRIX_MV, float4(0.0, 0.0, 0.0, 1.0)
                            ) - float4(v.vertex.x * scale.x, v.vertex.y * scale.y, 0.0, 0.0)
                        );
                        float2 uv = TRANSFORM_TEX(v.texcoord, _MainTex);
                        o.texcoord = float2(uv.x, 1 - uv.y);
                        UNITY_TRANSFER_FOG(o,o.vertex);
                        return o;
                    }

                    fixed4 frag(v2f i) : SV_Target
                    {
                        UNITY_SETUP_INSTANCE_ID(i);
                        fixed4 col = tex2D(
                            _MainTex, i.texcoord
                        ) * UNITY_ACCESS_INSTANCED_PROP(Props, _Color);
                        UNITY_APPLY_FOG(i.fogCoord, col);
                        return col;
                    }
                ENDCG
            }
    }
}
