using Mood_Analyser;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
            public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
            {
                string message = null;
                object expected = new MoodAnalyserDemo(message);
                //object expected1 = expected;
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserAppWithCore.MoodAnalyser", "MoodAnalyser");
                expected.Equals(obj);
                Assert.AreEqual(expected, obj);

            }
            [TestMethod]
            public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
            {
                object expected = new MoodAnalyserDemo("HAPPY");
                object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserAppWithCore.MoodAnalyser", "MoodAnalyser", "SAD");
                expected.Equals(obj);
            }

            [TestMethod]
            public void GivenMoodHappy_ShouldReturnHappy()
            {
                MoodAnalyserDemo obj = new MoodAnalyserDemo("HAPPY");
                string result = obj.analyseMood();
                Assert.AreEqual("HAPPY", result);

            }

            [TestMethod]
            [ExpectedException(typeof(MoodAnalyserCustomException))]
            public void GivenMoodNull_ShouldThrowException()
            {
                MoodAnalyserDemo obj = new MoodAnalyserDemo(null);
                string result = obj.analyseMood();
                //Assert.AreEqual("HAPPY", result);

            }


            [TestMethod]
            public void GivenMoodHappy_ShouldReturnNull()
            {
                MoodAnalyserDemo obj = new MoodAnalyserDemo("null");
                string result = obj.analyseMood();
                Assert.AreEqual("HAPPY", result);

            }


        

    }
}
