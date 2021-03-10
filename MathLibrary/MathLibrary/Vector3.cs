using System;

namespace MathClasses
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

        public static Vector3 operator+(Vector3 lhs, Vector3 rhs)
        {
            Vector3 result;
            result.x = lhs.x + rhs.x;
            result.y = lhs.y + rhs.y;
            result.z = lhs.z + rhs.z;

            return result;
        }

        public static Vector3 operator-(Vector3 lhs, Vector3 rhs)
        {
            Vector3 result;
            result.x = lhs.x - rhs.x;
            result.y = lhs.y - rhs.y;
            result.z = lhs.z - rhs.z;

            return result;
        }

        public static Vector3 operator*(Vector3 lhs, float rhs)
        {
            Vector3 result;
            result.x = lhs.x * rhs;
            result.y = lhs.y * rhs;
            result.z = lhs.z * rhs;

            return result;
        }

        public static Vector3 operator*(float lhs, Vector3 rhs)
        {
            Vector3 result;
            result.x = lhs * rhs.x;
            result.y = lhs * rhs.y;
            result.z = lhs * rhs.z;

            return result;
        }
        public float Magnitude()
        {
            return (float)Math.Sqrt((x * x) + (y * y) + (z * z));
        }

        public void Normalise()
        {
            float magnitude = Magnitude();
            if (magnitude != 0)
            {
                x /= magnitude;
                y /= magnitude;
                z /= magnitude;
            }
        }
        public float Dot(Vector3 rhs)
        {
            return (x * rhs.x) + (y * rhs.y) + (z * rhs.z);
        }

        public Vector3 Cross(Vector3 rhs)
        {
            Vector3 results;
            results.x = (y * rhs.z) - (z * rhs.y);
            results.y = (x * rhs.z) - (z * rhs.x);
            results.z = (x * rhs.y) - (y * rhs.x);

            return results;
        }
    }
}
