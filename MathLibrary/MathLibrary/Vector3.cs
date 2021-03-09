using System;

namespace MathLibrary
{
    public struct Vector3
    {
        public float x;
        public float y;
        public float z;

        public Vector3(float x = 0.0f, float y = 0.0f, float z = 0.0f)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        // V + V
        public static Vector3 operator+(Vector3 lhs, Vector3 rhs)
        {
            Vector3 result;
            result.x = lhs.x + rhs.x;
            result.y = lhs.y + rhs.y;
            result.z = lhs.z + rhs.z;

            return result;
        }
        // V - V
        public static Vector3 operator-(Vector3 lhs, Vector3 rhs)
        {
            Vector3 result;
            result.x = lhs.x - rhs.x;
            result.y = lhs.y - rhs.y;
            result.z = lhs.z - rhs.z;

            return result;
        }
        // V * F
        public static Vector3 operator*(Vector3 lhs, float rhs)
        {
            Vector3 result;
            result.x = lhs.x * rhs;
            result.y = lhs.y * rhs;
            result.z = lhs.z * rhs;

            return result;
        }
        // F * V
        public static Vector3 operator*(float lhs, Vector3 rhs)
        {
            Vector3 result;
            result.x = lhs * rhs.x;
            result.y = lhs * rhs.y;
            result.z = lhs * rhs.z;

            return result;
        }
    }
}
