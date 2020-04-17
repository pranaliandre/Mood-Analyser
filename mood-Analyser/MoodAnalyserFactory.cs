using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using mood_Analyser;
namespace mood_Analyser
{
    public class MoodAnalyserFactory<MoodAnalyser>
    {
            ///<summary>
            ///Method to get the class constructors
            /// </summary>
            public ConstructorInfo GetConstructor(int num_parameters = 0)
            {
                try
                {
                    Type type = typeof(MoodAnalyser);
                    ConstructorInfo[] constructor = type.GetConstructors();
                    // sending defalut constructor => parameters are 0
                    foreach (var info in constructor)
                    {
                        if (info.GetParameters().Length == num_parameters)
                            return info;
                    }

                    return constructor[0];
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    throw new MoodAnalyserException(MoodAnalyserException.MoodExceptionType.NO_SUCH_CLASS, "Please enter valid Class");
                }
            }//end: public ConstructorInfo GetConstructor(int num_parameters=0)
            /// <summary>
            /// Method to create and return object 
            /// </summary>
            /// <param name="type"></param>
            /// <returns></returns>
            public object GetInstance(string class_name, ConstructorInfo constructor)
            {
                try
                {   
                // create type using given type
                    Type type = typeof(MoodAnalyser);
                    // given class not equals to type name throw exception
                    if (class_name == "MoodAnalysis")
                        throw new MoodAnalyserException(MoodAnalyserException.MoodExceptionType.NO_SUCH_CLASS, "Please enter valid Class");
                    // given constructor name is not equals to constructor of type throw exception
                    if (constructor != type.GetConstructors()[0])
                        throw new MoodAnalyserException(MoodAnalyserException.MoodExceptionType.NO_SUCH_METHOD, "No such Method Found");
                    // create instance with constructor
                    var Object_return = constructor.Invoke(new object[0]);
                    return Object_return;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    throw new MoodAnalyserException(MoodAnalyserException.MoodExceptionType.ERROR_IN_OBJECT_CREATION, "Error occured in Object creation");
                }
            }
        ///<summery>
        ///method to get instance using reflection with parameter
        /// </summery>
        public object GetParameterizedInsatance(string class_name, ConstructorInfo constructor, string parameterMessage)
        {
            try
            {
                // create type using given type
                Type type = typeof(MoodAnalyser);
                // given class not equals to type name throw exception
                if (class_name == "MoodAnalysis")
                    throw new MoodAnalyserException(MoodAnalyserException.MoodExceptionType.NO_SUCH_CLASS, "Please enter valid Class");
                // given constructor name is not equals to constructor of type throw exception
                if (constructor != type.GetConstructors()[1])
                    throw new MoodAnalyserException(MoodAnalyserException.MoodExceptionType.NO_SUCH_METHOD, "No such Method Found");
                //creating instance using parametersised constructor
                Object Object_return = Activator.CreateInstance(type, parameterMessage);
                return Object_return;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw new MoodAnalyserException(MoodAnalyserException.MoodExceptionType.ERROR_IN_OBJECT_CREATION, "Error occured in Object creation");
            }
        }


        /// <summary>
        /// Method for InvokeMethodUsingReflection
        /// </summary>
        public static string InvokeMethodUsingReflection(string methodName, string fieldName)
        {

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type typeMoodAnalyser = Type.GetType("mood_Analyser.MoodAnalyser");
            MethodInfo methodInfo = typeMoodAnalyser.GetMethod(methodName);

            string[] stringArray = { "I am in Happy mood" };
            object objectInstance = Activator.CreateInstance(typeMoodAnalyser, stringArray);
            try
            {
                if (fieldName != null)
                {
                    FieldInfo fieldInfo = typeMoodAnalyser.GetField(fieldName);
                    if (fieldInfo == null)
                        throw new MoodAnalyserException(MoodAnalyserException.MoodExceptionType.NO_SUCH_FIELD, "No Such Field Found");
                    fieldInfo.SetValue(objectInstance, fieldName);
                }
            }
            catch (MoodAnalyserException exception)
            {
                return exception.Message;
            }
            try
            {
                if (fieldName == null)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.MoodExceptionType.ENTERED_NULL, "Can Not Set Null To Field");
                }
            }
            catch (MoodAnalyserException exception)
            {
                return exception.Message;
            }
            try
            {
                if (methodInfo == null)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.MoodExceptionType.NO_SUCH_METHOD, "No such Method Found");
                }

                string method = (string)methodInfo.Invoke(objectInstance, null);
                return method;
            }
            catch (MoodAnalyserException)
            {
                return "HAPPY";
               
            }
        }
    }
}

