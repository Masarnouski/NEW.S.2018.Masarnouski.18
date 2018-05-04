using System;
using System.IO;
using System.Linq;
using System.Text;
using Task2.Solution.Interfaces;

namespace Task_2
{
    public class RandomCharsFileGenerator:IGenerator
    {
        IStorage storage;

        public RandomCharsFileGenerator(IStorage storage)
        {
            this.storage = storage;
        }

        public string FileExtension => ".txt";

        public void GenerateFiles(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = this.GenerateFileContent(contentLength);

                var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";

                this.storage.WriteBytesToFile(generatedFileName, generatedFileContent);
            }
        }

        private byte[] GenerateFileContent(int contentLength)
        {
            var generatedString = this.RandomString(contentLength);

            var bytes = Encoding.Unicode.GetBytes(generatedString);

            return bytes;
        }

        private string RandomString(int Size)
        {
            var random = new Random();

            const string input = "abcdefghijklmnopqrstuvwxyz0123456789";

            var chars = Enumerable.Range(0, Size).Select(x => input[random.Next(0, input.Length)]);

            return new string(chars.ToArray());
        }
    }
}