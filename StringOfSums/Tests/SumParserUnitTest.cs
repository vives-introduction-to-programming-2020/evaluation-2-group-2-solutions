using StringOfSums;
using System;
using Xunit;

namespace Tests
{
    public class SumParserUnitTest
    {
        [Fact]
        public void TestSolveSum()
        {
            SumParser sumParser = new SumParser();

            Assert.Equal(12, sumParser.SolveSum("8+4"));
            Assert.Equal(200, sumParser.SolveSum("182+18"));
            Assert.Equal(18, sumParser.SolveSum("8+10"));
            Assert.Equal(42, sumParser.SolveSum("12+30"));
            Assert.Equal(0, sumParser.SolveSum("0+0"));
        }
    }
}
