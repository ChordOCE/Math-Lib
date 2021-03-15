using System;
using System.Collections.Generic;
using System.Text;

namespace MathClasses
{
    struct Matrix3
    {
        public float this[int i]
        {
            get
            {
                return m[i];
            }
            set
            {
                m[i] = value;
            }
        }
        public float[] m;

        public Matrix3(bool bDefault = true)
        {
            m = new float[9];
            m[0] = 1;
            m[1] = 0;
            m[2] = 0;
            m[3] = 0;
            m[4] = 1;
            m[5] = 0;
            m[6] = 0;
            m[7] = 0;
            m[8] = 1;

        }

        public Matrix3(float m0, float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8)
        {
            m = new float[9];
            m[0] = m0;
            m[1] = m1;
            m[2] = m2;
            m[3] = m3;
            m[4] = m4;
            m[5] = m5;
            m[6] = m6;
            m[7] = m7;
            m[8] = m8;
        }
        public static Vector3 operator*(Matrix3 a, Vector3 b)
        {
            Vector3 result;
            result.x = (a.m[0] * b.x) + (a.m[3] * b.y) + (a.m[6] * b.z);
            result.y = (a.m[1] * b.x) + (a.m[4] * b.y) + (a.m[7] * b.z);
            result.z = (a.m[2] * b.x) + (a.m[5] * b.y) + (a.m[8] * b.z);

            return result;
        }

        public static Matrix3 operator*(Matrix3 a, Matrix3 b)
        {
            Matrix3 bruh = new Matrix3();
            bruh[0] = a.m[0] * b.m[0] + a.m[3] * b.m[1] + a.m[6] * b.m[2];     bruh[3] = a.m[0] * b.m[3] + a.m[3] * b.m[4] + a.m[6] * b.m[5];     bruh[6] = a.m[0] * b.m[6] + a.m[3] * b.m[7] + a.m[6] * b.m[8];
            bruh[1] = a.m[1] * b.m[0] + a.m[4] * b.m[1] + a.m[7] * b.m[2];     bruh[4] = a.m[1] * b.m[3] + a.m[4] * b.m[4] + a.m[7] * b.m[5];     bruh[7] = a.m[1] * b.m[6] + a.m[4] * b.m[7] + a.m[7] * b.m[8];
            bruh[2] = a.m[2] * b.m[0] + a.m[5] * b.m[1] + a.m[8] * b.m[2];     bruh[5] = a.m[2] * b.m[3] + a.m[5] * b.m[4] + a.m[8] * b.m[5];     bruh[8] = a.m[2] * b.m[6] + a.m[5] * b.m[7] + a.m[8] * b.m[8];
            
            return bruh;
        }

        public void SetRotateX(float fRadians)
        {
            m[4] = (float)Math.Cos(fRadians);
            m[5] = (float)-Math.Sin(fRadians);
            m[7] = (float)Math.Sin(fRadians);
            m[8] = (float)Math.Cos(fRadians);
        }

        public void SetRotateY(float fRadians)
        {
        }

        public void SetRotateZ(float fRadians)
        {
        }
    }
}
