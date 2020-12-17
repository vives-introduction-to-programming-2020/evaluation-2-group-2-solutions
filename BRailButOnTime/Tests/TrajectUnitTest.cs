using BRailButOnTime;
using System;
using Xunit;

namespace Tests
{
    public class TrajectUnitTest
    {
        [Fact]
        public void TestLocationToString()
        {
            Location first = new Location("Aalst", "9300");
            Assert.Equal("Aalst [9300]", first.ToString());

            Location second = new Location("Charleroi", "6010");
            Assert.Equal("Charleroi [6010]", second.ToString());
        }

        [Fact]
        public void TestTrajectToString()
        {
            Location from = new Location("Brugge", "8200");
            Location to = new Location("Brussel", "1000");
            Traject traject = new Traject(from, to);
            Assert.Equal("Traject from Brugge [8200] to Brussel [1000]", traject.ToString());

            Location gent = new Location("Gent", "9000");
            Location diksmuide = new Location("Diksmuide", "8600");
            Traject second = new Traject(gent, diksmuide);
            Assert.Equal("Traject from Gent [9000] to Diksmuide [8600]", second.ToString());
        }
    }
}
