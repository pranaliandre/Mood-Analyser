using System;
using System.Collections.Generic;
using System.Text;

namespace mood_Analyser
{
    public class MoodAnalyserException : Exception
    {
        public enum MoodExceptionType
        {
            EMPTY,
            NULL
        }

        readonly MoodExceptionType ExceptionType;

        public MoodAnalyserException(MoodExceptionType ExceptionType, string exceptionMessage) : base(exceptionMessage)
        {
            this.ExceptionType = ExceptionType;
        }
    }
}
