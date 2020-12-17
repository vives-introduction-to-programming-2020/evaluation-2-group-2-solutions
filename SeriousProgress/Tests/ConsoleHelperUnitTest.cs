using SeriousProgress;
using System;
using Xunit;

namespace Tests
{
    public class ConsoleHelperUnitTest
    {
        [Fact]
        public void TestEmptyBar()
        {
            ConsoleHelper consoleHelper = new ConsoleHelper();

            Assert.Equal(
                  "------------\n"
                + "| ........ |\n"
                + "------------", consoleHelper.GenerateProgressBar(0, 8));

            Assert.Equal(
                  "--------------\n"
                + "| .......... |\n"
                + "--------------", consoleHelper.GenerateProgressBar(0, 10));

            Assert.Equal(
                  "------------------------\n"
                + "| .................... |\n"
                + "------------------------", consoleHelper.GenerateProgressBar(0, 20));
        }

        [Fact]
        public void TestFullBar()
        {
            ConsoleHelper consoleHelper = new ConsoleHelper();

            Assert.Equal(
                  "------------\n"
                + "| ######## |\n"
                + "------------", consoleHelper.GenerateProgressBar(8, 8));

            Assert.Equal(
                  "--------------\n"
                + "| ########## |\n"
                + "--------------", consoleHelper.GenerateProgressBar(10, 10));

            Assert.Equal(
                  "------------------------\n"
                + "| #################### |\n"
                + "------------------------", consoleHelper.GenerateProgressBar(20, 20));
        }

        [Fact]
        public void TestInBetween()
        {
            ConsoleHelper consoleHelper = new ConsoleHelper();

            Assert.Equal(
                  "------------\n"
                + "| ###..... |\n"
                + "------------", consoleHelper.GenerateProgressBar(3, 8));

            Assert.Equal(
                  "--------------\n"
                + "| ########.. |\n"
                + "--------------", consoleHelper.GenerateProgressBar(8, 10));

            Assert.Equal(
                  "------------------------\n"
                + "| #................... |\n"
                + "------------------------", consoleHelper.GenerateProgressBar(1, 20));

            Assert.Equal(
                  "------------------------\n"
                + "| ###################. |\n"
                + "------------------------", consoleHelper.GenerateProgressBar(19, 20));
        }

    }
}
