using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul
{
    public static class AviaryFactory
    {
        public static Aviary CreateAviary(string birdType)
        {
            switch (birdType.ToLower())
            {
                case "фламінго":
                    return new Aviary(birdType, 150, 9, 25); // Вольєр з сіткою та озером
                case "пінгвін":
                    return new Aviary(birdType, 8, 9, 10, 0); // Вольєр з озером та землею
                case "ківі":
                    return new Aviary(birdType, 45, 0, 0, 30); // Вольєр без водойми
                default:
                    return null;
            }
        }
    }
}
