using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Solution.Interfaces;
using Task_2;

namespace Task2.Tests
{
    public static class Program
    {
        public static void Main()
        {
            IGenerator charsGenerator = new RandomCharsFileGenerator(new BinaryStorage());
            IGenerator bytesGenerator = new RandomBytesFileGenerator(new XMLStorage());
            bytesGenerator.GenerateFiles(2, 123);
            charsGenerator.GenerateFiles(5, 897);
        }
    }
}
