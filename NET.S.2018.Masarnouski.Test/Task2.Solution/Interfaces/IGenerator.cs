using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Solution.Interfaces
{
    public interface IGenerator
    {
        void GenerateFiles(int filesCount, int contentLength);
    }
}
