using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Modul
{
    public interface IBirdReader
    {
        IEnumerable<string> ReadBirds(string filePath);
    }
}
