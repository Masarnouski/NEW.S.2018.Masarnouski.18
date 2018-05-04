using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Interfaces
{
    public interface ICheckerService
    {
         Tuple<bool, string> Verify(string password);
    }
}
