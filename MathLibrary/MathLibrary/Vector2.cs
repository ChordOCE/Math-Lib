using System;

namespace MathClasses
{
    public struct Vector2
    {
        public float x;
        public float y;

        public Vector2(float x = 0.0f, float y = 0.0f, float z = 0.0f)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            Vector2 result;
            result.x = lhs.x + rhs.x;
            result.y = lhs.y + rhs.y;

            return result;
        }

        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            Vector2 result;
            result.x = lhs.x - rhs.x;
            result.y = lhs.y - rhs.y;

            return result;
        }

        public static Vector2 operator *(Vector2 lhs, float rhs)
        {
            Vector2 result;
            result.x = lhs.x * rhs;
            result.y = lhs.y * rhs;

            return result;
        }

        public static Vector2 operator *(float lhs, Vector2 rhs)
        {
            Vector2 result;
            result.x = lhs * rhs.x;
            result.y = lhs * rhs.y;

            return result;
        }
        public float Magnitude()
        {
            return (float)Math.Sqrt((x * x) + (y * y));
        }

        public void Normalize()
        {
            float magnitude = Magnitude();
            if (magnitude != 0)
            {
                x /= magnitude;
                y /= magnitude;
            }
        }
        public float Dot(Vector2 rhs)
        {
            return (x * rhs.x) + (y * rhs.y);
        }
        public Vector2 GetRightAngle()
        {
            Vector2 result;
            result.x = -y;
            result.y = x;
            return result;
        }
        public static float GetAngleBetween(Vector2 lhs, Vector2 rhs)
        {
            lhs.Normalize();
            rhs.Normalize();
            float fDot = lhs.Dot(rhs);


            float angle = (float)Math.Acos(fDot);

            Vector2 rightangle = lhs.GetRightAngle();
            float fRightDot = rhs.Dot(rightangle);
            if (fRightDot < 0)
            {
                angle = angle * -1.0f;
            }

            return angle;
        }
    }
}
