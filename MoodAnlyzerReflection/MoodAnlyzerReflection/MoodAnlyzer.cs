using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MoodAnlyzerReflection
{
    public class MoodAnalyser
    {

        public static object CreateMoodAnalyse(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyse = assembly.GetType(className);
                    return Activator.CreateInstance(moodAnalyse);
                }
                catch (ArgumentException)
                {
                    throw new CustomAnalyse(CustomAnalyse.ExceptionType.NO_SUCH_CLASS, "Class not found");
                }
            }
            else
            {
                throw new CustomAnalyse(CustomAnalyse.ExceptionType.NO_SUCH_METHOD, "Constructor not found");
            }
        }
    }
}