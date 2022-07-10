using NUnit.Framework;
using MoodAnalyzerProblem;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckHappyMood()
        {
           
            //Arrange
            MoodAnalyse moodAnalyse = new MoodAnalyse("I am very Happy");

            //Act
            string checkhappymood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual("HAPPY MOOD", checkhappymood);
        }

        [Test]
        public void CheckSadMood()
        {

            //Arrange
            MoodAnalyse moodAnalyse = new MoodAnalyse("I am very Sad");

            //Act
            string checksadmood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual("SAD MOOD", checksadmood);
        }
    }
}