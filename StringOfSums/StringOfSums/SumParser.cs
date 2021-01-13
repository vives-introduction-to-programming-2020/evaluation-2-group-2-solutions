using System;
using System.Collections.Generic;
using System.Text;

namespace StringOfSums
{
    public class SumParser
    {
        public int SolveSum(string text)
        {
            // TODO - Parse the sum contained in "text" and solve it
            // TODO - Return the result
            //
            //      Example of text: "142+223"
            //
            //      This method should than return 365
            //
            // "text" contains valid value (not empty, with plus sign and two positive integers)

            //////////////////////////////////
            /// Option 1 - Basic Construct ///
            //////////////////////////////////

            //// Find the plus sign
            //int iPlus = 0;
            //while (text[iPlus] != '+')
            //{
            //    iPlus++;
            //}

            //// Determine left part
            //string left = "";
            //for (int i = 0; i < iPlus; i++)
            //{
            //    left += text[i];
            //}

            //// Determine right part
            //string right = "";
            //for (int i = iPlus + 1; i < text.Length; i++)
            //{
            //    right += text[i];
            //}


            ///////////////////////////////////////
            /// Option 2 - Using String methods ///
            ///////////////////////////////////////

            int iPlus = text.IndexOf('+');
            string left = text.Substring(0, iPlus);
            string right = text.Substring(iPlus+1, text.Length-(iPlus+1));



            return Convert.ToInt32(left) + Convert.ToInt32(right);
        }
    }
}
