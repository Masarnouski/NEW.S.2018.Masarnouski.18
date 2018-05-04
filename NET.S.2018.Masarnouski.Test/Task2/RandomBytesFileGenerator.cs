using System;
using System.IO;
using Task2.Solution.Interfaces;

namespace Task_2
{
    public class RandomBytesFileGenerator: IGenerator
    {
        IStorage storage;

        public RandomBytesFileGenerator(IStorage storage)
        {
            this.storage = storage;
        }

        public string FileExtension => ".bytes";

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
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }
    }
}