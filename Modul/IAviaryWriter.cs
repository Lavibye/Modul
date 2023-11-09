using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Modul
{
    public interface IAviaryWriter
    {
        void WriteAviaries(string filePath, IEnumerable<Aviary> aviaries);
        void WriteCalculations(string filePath, string calculationsText);
    }
}
