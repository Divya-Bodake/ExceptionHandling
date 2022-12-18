using ExceptionHandlingMoodAnalyser;

namespace MoodAnalyserProblemTest
{
    public class Tests
    {

        [Test]
        public void GivenSadMood_WhenAnalyzed_ShouldReturnSad()
        {
            //Arrange
            string message = "I am in Sad Mood";
            string expected = "Sad";
            MoodAnalyser analyse = new MoodAnalyser(message);
            //Act
            string mood = analyse.AnalyzeMood();
            //Assert
            Assert.AreEqual(expected, mood);
        }
        [Test]
        public void GivenAnyMood_WhenAnalyzed_ShouldReturnHappy()
        {
            //Arrange
            string message = "I am in Any Mood";
            string expected = "Happy";
            MoodAnalyser analyse = new MoodAnalyser(message);
            //Act
            string mood = analyse.AnalyzeMood();
            //Assert
            Assert.AreEqual(expected, mood);
        }
        [Test]
        public void GivenNullMood_WhenAnalyzed_ShouldReturnHappy()
        {
            //Arrange
            MoodAnalyser analyse = new MoodAnalyser(null);
            //Act
            string result = analyse.AnalyzeMood();
            Assert.AreEqual(result, "Happy");
        }
        [Test]
        public void GivenNullMessage_ThrowsMoodAnalysisExceptionNullMessage()
        {
            try
            {
                //Arrange
                string message = null;
                MoodAnalyser analyse = new MoodAnalyser(message);
                //Act
                string mood = analyse.AnalyzeMood();
            }
            catch (MoodAnalyzerCustomException ex)
            {
                Assert.AreEqual("Message should not be null", ex.Message);
            }
        }
        [Test]
        public void GivenEmptyMessage_ThrowsMoodAnalysisExceptionEmptyMessage()
        {
            try
            {
                //Arrange
                string message = " ";
                MoodAnalyser analyse = new MoodAnalyser(message);
                //Act
                string mood = analyse.AnalyzeMood();
            }
            catch (MoodAnalyzerCustomException ex)
            {
                Assert.AreEqual("Message should not be Empty", ex.Message);
            }
        }
    }
}