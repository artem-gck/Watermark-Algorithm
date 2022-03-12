using Lab_6.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class WaveAudio
    {
        private byte[] data;

        internal bool EncryptData(string text)
        {
            return Lsb.Encrypt(this.data, text);
        }

        internal string DecryptData(int size)
        {
            return Lsb.Decrypt(this.data, size);
        }

        internal bool LoadFile(string path)
        {
            try
            {
                this.data = File.ReadAllBytes(path);

                return true;
            }
            catch
            {
                return false;
            }
        }

        internal bool SaveFile(string path)
        {
            try
            {
                File.WriteAllBytes(path, this.data);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
