using System;

namespace MoodAnalyzerProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyse moodanalyse = new MoodAnalyse("I am very Happy");
            string checkmood = moodanalyse.AnalyseMood();
            Console.WriteLine(checkmood);

            
          

        }






    }
}
