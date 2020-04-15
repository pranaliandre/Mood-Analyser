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
        /// Analyse mood method unit  - return sad mood
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
        /// <summary>
        /// Analyse mood method unit  - return sad mood
        /// </summary>
        [Test]
        public void GivenHappyMood_WhenProper_ShouldReturnHappy()
        {
            string expected = "happy";
            string message = "i am in any mood";
            MoodAnalyser object_Mood = new MoodAnalyser(message);
            string mood = object_Mood.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// Analyse mood method unit - throw null exception
        /// </summary>
        [Test]
        public void GivenNullMood_ShouldthrowException()
        {
            string expected = "Please enter proper mood.";
            string message = null;
            MoodAnalyser object_Mood = new MoodAnalyser(message);
            try
            {
                string mood = object_Mood.AnalyseMood();
                Assert.AreEqual(expected, mood);
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        /// Analyse mood method unit - throw empty exception
        /// </summary>
        [Test]
        public void GivenEmptyMood_ShouldThrowException()
        {
            string expected = "Please Enter proper mood.";
            string message = "";
            MoodAnalyser object_Mood = new MoodAnalyser(message);
            try
            {
                string mood = object_Mood.AnalyseMood();
                Assert.AreEqual(expected, mood);
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
}