using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6.Algorithms
{
    internal static class Lsb
    {
        private const int offset = 56;

        internal static bool Encrypt(byte[] data, string text)
        {
            var byteText = Encoding.UTF8.GetBytes(text);

            for (var i = offset; i < byteText.Length + offset; i++)
            {
                var byteS = byteText[(i - offset)];

                for (var j = 0; j < 8; j++)
                {
                    var m = (byte)(byteS >> (7 - j));

                    m &= 1;

                    data[(i - offset) * 8 + j + offset] >>= 1;
                    data[(i - offset) * 8 + j + offset] <<= 1;

                    data[(i - offset) * 8 + j + offset] |= m;
                }
            }

            return true;
        }

        internal static string Decrypt(byte[] data, int textSize)
        {
            var text = new List<byte>(textSize);

            for (var i = offset; i < textSize + offset; i++)
            {
                byte byteStr = 0;

                for (var j = 0; j < 8; j++)
                {
                    var bit = data[(i - offset) * 8 + j + offset] & 1;

                    var m = (byte)(bit << (7 - j));

                    byteStr |= m;
                }

                text.Add(byteStr);
            }

            return Encoding.UTF8.GetString(text.ToArray());
        }
    }
}
