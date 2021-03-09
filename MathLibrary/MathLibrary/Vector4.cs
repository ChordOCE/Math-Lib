using System;

namespace MathClasses
{
    public struct Vector4
    {
        public float x;
        public float y;
        public float z;
        public float w;


        public Vector4(float x = 0.0f, float y = 0.0f, float z = 0.0f, float w = 0.0f)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        //V + V
        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            Vector4 result;
            result.x = lhs.x + rhs.x;
            result.y = lhs.y + rhs.y;
            result.z = lhs.z + rhs.z;
            result.w = lhs.x + rhs.w;

            return result;
        }
        //V - V
        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            Vector4 result;
            result.x = lhs.x - rhs.x;
            result.y = lhs.y - rhs.y;
            result.z = lhs.z - rhs.z;
            result.w = lhs.w - rhs.w;

            return result;
        }
        //V * F
        public static Vector4 operator *(Vector4 lhs, float rhs)
        {
            Vector4 result;
            result.x = lhs.x * rhs;
            result.y = lhs.y * rhs;
            result.z = lhs.z * rhs;
            result.w = lhs.w * rhs;

            return result;
        }
        // F * V
        public static Vector4 operator *(float lhs, Vector4 rhs)
        {
            Vector4 result;
            result.x = lhs * rhs.x;
            result.y = lhs * rhs.y;
            result.z = lhs * rhs.z;
            result.w = lhs * rhs.w;

            return result;
        }
        //Magnitude function
        public float Magnitude()
        {
            return (float)Math.Sqrt((x * x) + (y * y) + (z * z) + (w * w));
        }
        public void Normalise()
        {
            float magnitude = Magnitude();
            if (magnitude != 0)
            {
                x /= magnitude;
                y /= magnitude;
                z /= magnitude;
                w /= magnitude;
            }
        }
        public float Dot(Vector4 rhs)
        {
            return (x * rhs.x) + (y * rhs.y) + (z * rhs.z) + (w * rhs.w);
        }
        public Vector4 Cross(Vector4 rhs)
        {
            Vector4 results;
            results.x = (y * rhs.y) - (z * rhs.z);
            results.y = (x * rhs.x) - (z * rhs.z);
            results.z = (x * rhs.x) - (y * rhs.y);
            results.w = 0;
            return results;
        }
    }
}
