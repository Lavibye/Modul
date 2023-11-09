using System.IO;
using Xunit;
using System.Collections.Generic;

namespace UnitTest
{
    using Modul;
    using Xunit;

    public class AviaryFactoryTests
    {
        [Fact]
        public void CreateAviary_ShouldCreateFlamingoAviary_WhenBirdTypeIsFlamingo()
        {
            var birdType = "פכאל³םדמ";

            var aviary = AviaryFactory.CreateAviary(birdType);

            Assert.NotNull(aviary);
            Assert.Equal(birdType, aviary.BirdType);
            Assert.Equal(150, aviary.LandArea);
            Assert.Equal(9, aviary.WaterArea);
            Assert.Equal(25, aviary.TemperatureWater);
            Assert.Null(aviary.TemperatureAir);
        }

        [Fact]
        public void CreateAviary_ShouldCreatePenguinAviary_WhenBirdTypeIsPenguin()
        {
            var birdType = "ן³םדג³ם";

            var aviary = AviaryFactory.CreateAviary(birdType);

            Assert.NotNull(aviary);
            Assert.Equal(birdType, aviary.BirdType);
            Assert.Equal(8, aviary.LandArea);
            Assert.Equal(9, aviary.WaterArea);
            Assert.Equal(10, aviary.TemperatureWater);
            Assert.Equal(0, aviary.TemperatureAir);
        }

        [Fact]
        public void CreateAviary_ShouldReturnNull_WhenBirdTypeIsUnknown()
        {
            var birdType = "םוג³המלטי";

            var aviary = AviaryFactory.CreateAviary(birdType);

            Assert.Null(aviary);
        }
    }
    public class BirdReaderTests
    {
        [Fact]
        public void ReadBirds_ShouldReturnListOfBirds_WhenFileExists()
        {
            var filePath = "test_birds.txt";
            var expectedBirds = new List<string> { "פכאל³םדמ", "ן³םדג³ם", "ך³ג³" };
            File.WriteAllLines(filePath, expectedBirds);

            var birdReader = new BirdReader();

            var birds = birdReader.ReadBirds(filePath);

            Assert.Equal(expectedBirds.Count, birds.Count());
            Assert.All(birds, bird => expectedBirds.Contains(bird));

            File.Delete(filePath);
        }

        [Fact]
        public void ReadBirds_ShouldThrowFileNotFoundException_WhenFileDoesNotExist()
        {
            var filePath = "nonexistent.txt";
            var birdReader = new BirdReader();

            Assert.Throws<FileNotFoundException>(() => birdReader.ReadBirds(filePath));
        }
    }
}