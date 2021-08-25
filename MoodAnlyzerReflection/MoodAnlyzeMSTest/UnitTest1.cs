using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnlyzerReflection;

namespace MoodAnalyseMsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GiveClassNameAndReturnObjectUsingParameters()
        {
            ///string message = null;
            object expected = new Analyser("Happy");
            object obj = MoodAnalyser.CreateMoodAnalyse("MoodAnalyserUsingReflection.Mood", "Mood", "Happy");
            expected.Equals(obj);
            //Assert.Equals(expected, obj);
        }
    }
}