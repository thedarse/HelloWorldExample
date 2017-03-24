using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace HelloWorldUnitTests
{
    [TestClass]
    public class HelloWorldUnitTests
    {
        /// <summary>
        /// This method tests if the value passed to the method to be used in writing is in fact hello world.
        /// This is the only unit test required for this class.
        /// </summary>
        [TestMethod]
        public void TestIfValueIsHelloWorld()
        {
            new HelloWorldAPI(str => { Assert.AreEqual(str, "Hello World!"); }).WriteHelloWorld();
        }

    }
}
