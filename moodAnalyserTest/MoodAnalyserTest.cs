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
        /// Analyse mood method unit test - return null
        /// </summary>
        [Test]
        public void GivenNull_ShouldReturnNull()
        {
            string expected = "happy";
            string message = null;
            MoodAnalyser obj_mood = new MoodAnalyser(message);
            string mood = obj_mood.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }
    }
}