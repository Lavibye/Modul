using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul
{
    public class AviaryWriter : IAviaryWriter
    {
        public void WriteAviaries(string filePath, IEnumerable<Aviary> aviaries)
        {
            try
            {
                using (var writer = new StreamWriter(filePath))
                {
                    foreach (var aviary in aviaries)
                    {
                        writer.WriteLine($"{aviary.BirdType},{aviary.CalculateTotalArea()},{aviary.WaterArea},{aviary.TemperatureWater}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при запису файлу: {ex.Message}");
            }
        }

        public void WriteCalculations(string filePath, string calculations)
        {
            using (var writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(calculations);
            }
        }
    }
}
