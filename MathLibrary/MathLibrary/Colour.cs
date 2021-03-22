
using System;
using System.Collections.Generic;
using System.Text;

namespace MathClasses
{
    public class Colour
    {
        public uint colour = 0;
        public Colour(byte red, byte green, byte blue, byte alpha)
        {
            colour = (uint)((red << 24) + (green << 16) + (blue << 8) + alpha);
        }

        public void SetRed(byte red)
        {
            colour &= colour & 0x00FFFFFF;
            colour |= colour | (uint)(colour << 24);
        }
        public void SetGreen(byte green)
        {
            colour &= colour & 0x00FFFFFF;
            colour |= colour | (uint)(colour << 16);
        }

        public void SetBlue(byte blue)
        {
            colour &= colour & 0x00FFFFFF;
            colour |= colour | (uint)(colour << 8);
        }

        public void SetAlpha(byte alpha)
        {
            colour &= colour & 0x00FFFFFF;
            colour |= colour | (uint)(colour << 0);
        }

        public byte GetRed()
        {
            return (byte)((colour >> 24));
        }

        public byte GetGreen()
        {
            return (byte)((colour >> 16));
        }

        public byte GetBlue()
        {
            return (byte)(colour >> 8);
        }

        public byte GetAlpha()
        {
            return (byte)(colour >> 0);
        }
    }
}