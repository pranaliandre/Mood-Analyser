using System;

namespace mood_Analyser
{
    public class MoodAnalyser
    {
        private string message;

        /// <summary>
        /// default constructor
        /// </summary>
        public MoodAnalyser() { }
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="message"> message </param>

        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// analyze mood method
        /// </summary>
        /// <returns> happy or sad depending upon message </returns>
        public string AnalyseMood()
        {
            try
            {
                if (message.Contains("sad", StringComparison.OrdinalIgnoreCase))
                    return "sad";
                else
                    return "happy";
            }
            catch
            {
                return "happy";
            }
        }
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser");
        }

    }
}
