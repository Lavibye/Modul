using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul
{
    public class Aviary
    {
        public string BirdType { get; }
        public double LandArea { get; }
        public double WaterArea { get; }
        public double? TemperatureWater { get; }
        public double? TemperatureAir { get; }

        public Aviary(string birdType, double landArea, double waterArea, double temperatureWater, double? temperatureAir = null)
        {
            BirdType = birdType;
            LandArea = landArea;
            WaterArea = waterArea;
            TemperatureWater = temperatureWater;
            TemperatureAir = temperatureAir;
        }

        public double CalculateTotalArea()
        {
            return LandArea + WaterArea;
        }
    }
}
