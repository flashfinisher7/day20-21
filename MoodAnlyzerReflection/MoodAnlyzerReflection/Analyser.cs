
using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnlyzerReflection
{
    public class Analyser
    {
        private string message;
        public Analyser(string message)
        {
            this.message = message;
        }
        public Analyser()
        {

        }
        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new CustomAnalyse(CustomAnalyse.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomAnalyse(CustomAnalyse.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }
    }
}