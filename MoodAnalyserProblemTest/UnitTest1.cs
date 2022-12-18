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
    }
}