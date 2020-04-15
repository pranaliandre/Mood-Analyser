using NUnit.Framework;
using mood_Analyser;
namespace moodAnalyserTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        /// <summary>
        /// Analyse sad mood method 
        /// </summary>
        [Test]
        public void GivenSadMood_WhenProper_ShouldReturnSad()
        {
            string expected = "sad";
            string message = "i am in sad mood";
            MoodAnalyser object_Mood = new MoodAnalyser(message);
            string mood = object_Mood.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }
    }
}