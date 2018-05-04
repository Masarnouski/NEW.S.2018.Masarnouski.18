using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Solution.Interfaces
{
    public interface IStorage
    {
        void WriteBytesToFile(string fileName, byte[] content);
    }
}
