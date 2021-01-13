using System;
using System.Collections.Generic;
using System.Text;

namespace SeriousProgress
{
    public class ConsoleHelper
    {
        public string GenerateProgressBar(int progress, int maximum)
        {
            // TODO - Generate a progress bar based on the given arguments
            //      - "progress": the current progress value
            //      - "maximum": the total maximum progress value (determines length of the bar).
            // Example:
            //      ---------
            //      | ##... |
            //      ---------
            //
            //      progress = 2
            //      maximum = 5

            string output = "";

            //////////////////////////////////
            /// Option 1 - No extra method ///
            //////////////////////////////////

            //// First line
            //for (int i = 0; i < maximum + 4; i++)
            //{
            //    output += "-";
            //}
            //output += "\n";     // Newline

            //// Progress part
            //output += "| ";
            //for (int i = 0; i < progress; i++)
            //{
            //    output += "#";
            //}
            //for (int i = progress; i < maximum; i++)
            //{
            //    output += ".";
            //}
            //output += " |\n";

            //// Last line
            //for (int i = 0; i < maximum + 4; i++)
            //{
            //    output += "-";
            //}

            //////////////////////////////////////////////////
            /// Option 2 - Nice and DRY with custom method ///
            //////////////////////////////////////////////////


            output += GenerateLine("-", maximum + 4) + "\n";
            output += "| " + GenerateLine("#", progress) + GenerateLine(".", maximum - progress) + " |\n";
            output += GenerateLine("-", maximum + 4);

            return output;
        }

        // Private custom method to generate line of chars
        private string GenerateLine(string symbol, int count)
        {
            string output = "";
            for (int i = 0; i < count; i++)
            {
                output += symbol;
            }
            return output;
        }
    }
}
