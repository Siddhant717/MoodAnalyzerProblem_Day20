using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyse
    {
        public string message;
        public MoodAnalyse(string message)
        {
            this.message = message;
        }
        //Creating method for Analysing the mood
        public string AnalyseMood()
        {
            if (message.Contains("Happy"))
            {
                return "HAPPY MOOD";
            }
            else
            {
                return "SAD MOOD";
            }
        }
    }
}
