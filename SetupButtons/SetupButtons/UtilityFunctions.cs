using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetupButtons
{
    class ReportAction
    {
        public static void PositiveReport(string Actual)
        {
            Ranorex.Report.Success("Sucessfully Performed", Actual);
        }

        public static void NegativeReport(string Actual, string Hardcoded)
        {
            string strRealText = "Actual Text is: " + Actual;
            Ranorex.Report.Error(strRealText);

            string strExpectedText = "Hardcoded Text is: " + Hardcoded;
            Ranorex.Report.Error(strExpectedText);
        }
    }

    class StringCopare
    {
        public static void Text(string Actual, string Hardcoded)
        {
            string RealText = Actual;
            string HardcodedText = Hardcoded;

            if (RealText == HardcodedText)
            {
                ReportAction.PositiveReport(RealText);
            }

            else
                ReportAction.NegativeReport(RealText, HardcodedText);
        }
    }
}
