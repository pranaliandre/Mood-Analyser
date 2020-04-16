using System;
using System.Collections.Generic;
using System.Text;

namespace mood_Analyser
{
    public class MoodAnalyserException : Exception
    {
        //enumeration of custom exception
        public enum MoodExceptionType
        {
            NULL,
            EMPTY,
            ERROR_IN_OBJECT_CREATION,
            NO_SUCH_CLASS,
            NO_SUCH_METHOD
        }

        private MoodExceptionType exceptionType;

        public MoodAnalyserException(MoodExceptionType exceptionType, string exceptionMessage) : base(exceptionMessage)
        {
            this.exceptionType = exceptionType;
        }
    }
}
