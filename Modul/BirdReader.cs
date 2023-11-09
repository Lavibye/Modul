using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Modul
{
    public class BirdReader : IBirdReader
    {
        public IEnumerable<string> ReadBirds(string filePath)
        {
            var birdNames = new List<string>();

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Файл не знайдено.", filePath);
            }

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                birdNames.Add(line.Trim());
            }

            return birdNames;
        }
    }
}
