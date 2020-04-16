using System;
using mood_Analyser;
namespace mood_Analyser
{
    public class MoodAnalyser
    {
        string message;

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
                //exception handled if user inputs null
                if (message == null)
                {
                    //Calling MoodAnalyserException(Exception type->enum, message)
                    throw new MoodAnalyserException(MoodAnalyserException.MoodExceptionType.NULL, "Please enter proper mood.");
                }
                //exception handled if user inputs nothing
                if (message.Length == 0)
                {
                    //Calling MoodAnalyserException(Exception type->enum, message)
                    throw new MoodAnalyserException(MoodAnalyserException.MoodExceptionType.EMPTY, "Please Enter proper mood.");
                }
                if (message.Contains("sad", StringComparison.OrdinalIgnoreCase))
                    return "sad";
                else
                    return "happy";
            }
            catch (NullReferenceException exception)
            {
                return exception.Message;
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
