using NUnit.Framework;
using mood_Analyser;
using System.Reflection;
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
        /// <summary>
        /// To analyse Given MoodAnalyser Should Return MoodAanalyser Object with default constructor.
        /// </summary>
        [Test]
        public void GivenMoodAnalyser_ShouldReturnMoodAnalyser_WithDefaultConstructor()
        {
            object expected = new MoodAnalyser();
            // create object for MoodAnalyserFactory and get default constructor of class MoodAnalyser
            MoodAnalyserFactory<MoodAnalyser> object_mood = new MoodAnalyserFactory<MoodAnalyser>();
            ConstructorInfo constructorInfo = object_mood.GetConstructor();
            try
            {
                // create instace for MoodAnalysis by calling GetInstance Method
                object object_compare = object_mood.GetInstance("MoodAnalyser", constructorInfo);
                //Assert.AreEqual(new MoodAnalyser(), obj_compare);
                expected.Equals(object_compare);
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
        /// <summary>
        /// To analyser given mood Analyser class improper should return throw exception
        /// </summary>
        [Test]
        public void GivenMoodAnalyserClassImproper_ShouldReturnThrowException_WithDefaultConstructor()
        {
            object expected = "Please enter valid Class";
            // create object for moodanalyserfactory and get default constructor of class MoodAnalyser
            MoodAnalyserFactory<MoodAnalyser> object_mood = new MoodAnalyserFactory<MoodAnalyser>();
            ConstructorInfo constructorInfo = object_mood.GetConstructor();
            try
            {
                // create instace for MoodAnalyser by calling GetInstance Method
                object object_compare = object_mood.GetInstance("DemoClass", constructorInfo);
                expected.Equals(object_compare);
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
        /// <summary>
        /// To analyser given mood Analyser class and constructor improper should return throw exception
        /// </summary>
        [Test]
        public void GivenMoodAnalyserMethodImproper_ShouldReturnMoodAnalyser_WithDefaultConstructor()
        {
            object expected = "No such Method Found";
            // create object for moodfactory and get default constructor of class MoodAnalyser
            MoodAnalyserFactory<MoodAnalyser> object_mood = new MoodAnalyserFactory<MoodAnalyser>();
            ConstructorInfo constructorInfo = object_mood.GetConstructor();
            try
            {
                // create instace for MoodAnalysis by calling GetInstance Method
                object object_compare = object_mood.GetInstance("demomethod", constructorInfo);
                //Assert.AreEqual(new MoodAnalyser(), obj_compare);
                expected.Equals(object_compare);
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
        /// <summary>
        /// Test to given Moodanalyser when proper return mood analyser object with parameterized constructor.
        /// </summary>
        [Test]
        public void GivenMoodAnalyser_ShouldReturnMoodAnalyser_WithParameterizedConstructor()
        {
            object expected = new MoodAnalyser();
            // create object for moodfactory and get default constructor of class MoodAnalyser
            MoodAnalyserFactory<MoodAnalyser> object_mood = new MoodAnalyserFactory<MoodAnalyser>();
            ConstructorInfo constructorInfo = object_mood.GetConstructor(1);
            string message = "I am in Sad Mood";
            try
            {
                // create instace for MoodAnalyser by calling GetInstance Method
                object object_compare = object_mood.GetParameterizedInsatance("MoodAnalyser", constructorInfo, message);
                expected.Equals(object_compare);
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
        /// <summary>
        /// Test to given mood analyser class inmproper should return throw exception
        /// </summary>
        [Test]
        public void GivenMoodAnalyserClassImproper_ShouldReturnThrowException_WithParameterizedConstructor()
        {
            object expected = "Please enter valid Class";
            // create object for moodfactory and get default constructor of class MoodAnalyser
            MoodAnalyserFactory<MoodAnalyser> object_mood = new MoodAnalyserFactory<MoodAnalyser>();
            ConstructorInfo constructorInfo = object_mood.GetConstructor(1);
            string message = "I am in Sad Mood";
            try
            {
                // create instace for MoodAnalyser by calling GetInstance Method
                object object_compare = object_mood.GetParameterizedInsatance("Democlass", constructorInfo, message);
                expected.Equals(object_compare);
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
        /// <summary>
        /// Test to given mood analyser class and constructor improper sholud throw exception 
        /// </summary>
        [Test]
        public void GivenMoodAnalyserClassAndConstructorImproper_ReturnThrowException_WithParameterizedConstructor()
        {
            object expected = "No such Method Found";
            // create object for moodfactory and get default constructor of class MoodAnalyser
            MoodAnalyserFactory<MoodAnalyser> object_mood = new MoodAnalyserFactory<MoodAnalyser>();
            ConstructorInfo constructorInfo = object_mood.GetConstructor(1);
            string message = "I am in Sad Mood";
            try
            {
                // create instace for MoodAnalyser by calling GetInstance Method
                object object_compare = object_mood.GetParameterizedInsatance("DemoMethod", constructorInfo, message);
                expected.Equals(object_compare);
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
        /// <summary>
        /// Test for invoke the method using reflection given happy message return happy message
        /// </summary>
        [Test]
        public void MethodInvoke_UsingReflection_shouldReturnHappy()
        {
            string actual = MoodAnalyserFactory<MoodAnalyser>.InvokeMethodUsingReflection("AnalyseMood", "HAPPY");
            string Expected = "HAPPY";
            Expected.Equals(actual);
        }
        /// <summary>
        /// Test for given Happy message improper method throw exception
        /// </summary>
        public void GivenImproperMethod_throwException()
        {
            string actual = MoodAnalyserFactory<MoodAnalyser>.InvokeMethodUsingReflection("AnalyseMood", "Improper_Method_Name");
            string Expected = "No such Method Found";
            Assert.AreEqual(Expected, actual);
        }
    }
}