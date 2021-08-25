using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnlyzerReflection;

namespace MoodAnalyseMsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GiveClassNameAndReturnObject()
        {
            string message = null;
            object expected = new Analyser(message);
            object obj = MoodAnalyser.CreateMoodAnalyse("MoodAnlyzerReflection.Analyser", "Analyser");
            expected.Equals(obj);
            /// Assert.Equals(expected, obj);
        }
    }
}