using System;

namespace HelloWorld
{
    /// <summary>
    /// immutable obect for writing Hello World to a given action
    /// </summary>
    public class HelloWorldAPI
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="outFunc"></param>
        public HelloWorldAPI(Action<string> outFunc)
        {
            outputMethod = outFunc;
        }

        /// <summary>
        /// Delegate to pass hello world to
        /// </summary>
        private Action<string> outputMethod;

        /// <summary>
        /// Hello World string static variable
        /// </summary>
        private static string hello = "Hello World!";

        /// <summary>
        /// Write hello world to action
        /// </summary>
        public void WriteHelloWorld()
        {
            outputMethod(hello);
        }
    }
}
