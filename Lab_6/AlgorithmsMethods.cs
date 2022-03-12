using Lab_6;
using Lab_6.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    /// <summary>
    /// AlgorithmsMethods class.
    /// </summary>
    public static class AlgorithmsMethods
    {
        private const string CryptChoose = "1. Encrypt data\n2. Decrypt data";
        private const string Choice = "Input your choise: ";
        private const string Massage = "Input massage: ";
        private const string InputPath = "Input path to input file: ";
        private const string OutputPath = "Output path to output file: ";
        private const string LengthOfFile = "Length of file: ";

        /// <summary>
        /// AlGamal method.
        /// </summary>
        /// <returns></returns>
        public static bool Lsb()
        {
            Console.WriteLine(CryptChoose);
            var choose = ConsoleValidation.ValidateInt(Choice, 1, 2);

            switch (choose)
            {
                case 1:
                    Console.Write(InputPath);
                    var inputPath = Console.ReadLine();

                    Console.Write(OutputPath);
                    var outputPath = Console.ReadLine();

                    Console.WriteLine(Massage);
                    var text = Console.ReadLine();

                    FileWorker.EncryptFile(inputPath, outputPath, text);

                    return true;

                    break;

                case 2:

                    Console.Write(InputPath);
                    inputPath = Console.ReadLine();

                    var lengthOfText = ConsoleValidation.ValidateInt(LengthOfFile);

                    var answer = FileWorker.DecryptFile(inputPath, lengthOfText);

                    Console.WriteLine(answer);

                    return true;

                    break;

                default:
                    return false;
            }
        }
    }
}
