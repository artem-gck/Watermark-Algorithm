using Lab_6.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    /// <summary>
    /// FileWorker class.
    /// </summary>
    public static class FileWorker
    { 
        /// <summary>
        /// Encrypts the file.
        /// </summary>
        /// <param name="inputPath">The input path.</param>
        /// <param name="outputPath">The output path.</param>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public static bool EncryptFile(string inputPath, string outputPath, string text)
        {
            var audio = new WaveAudio();

            audio.LoadFile(inputPath);
            var result = audio.EncryptData(text);
            audio.SaveFile(outputPath);

            return result;
        }

        /// <summary>
        /// Decrypts the file.
        /// </summary>
        /// <param name="inputPath">The input path.</param>
        /// <param name="outputPath">The output path.</param>
        /// <param name="p">The p.</param>
        /// <param name="x">The x.</param>
        /// <returns></returns>
        public static string DecryptFile(string inputPath, int lengthOfText)
        {
            var audio = new WaveAudio();

            audio.LoadFile(inputPath);
            var result = audio.DecryptData(lengthOfText);

            return result;
        }
    }
}
