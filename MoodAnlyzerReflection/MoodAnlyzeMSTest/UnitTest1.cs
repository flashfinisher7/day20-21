using System;
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
        public void GiveInvokeMethod()
        {

            string actual;
            string message = "I am in a Happy mood";
            string methodName = "AnalyseMood";
            string expected = "Happy";


            try
            {
                MoodAnalyser ma = new MoodAnalyser();
                actual = ma.InvokeMethod(methodName, message);
            }
            catch (CustomAnalyse e)
            {
                throw new Exception(e.Message);
            }
            Assert.AreEqual(expected, actual);

        }
        public void GiveInvokeMethodThrowException()
        {

            string actual;
            string message = "I am in a Happy mood";
            string methodName = "Mood";
            string expected = "Happy";


            try
            {
                MoodAnalyser ma = new MoodAnalyser();
                actual = ma.InvokeMethod(methodName, message);
            }
            catch (CustomAnalyse e)
            {
                throw new Exception(e.Message);
            }
            Assert.AreEqual(expected, actual);

        }
    }
}