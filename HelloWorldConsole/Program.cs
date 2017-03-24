using System;
using HelloWorld;

namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            new HelloWorldAPI(Console.WriteLine).WriteHelloWorld();
            Console.ReadLine();
        }

        /// <summary>
        /// how to write hello world to a database
        /// </summary>
        static void WriteToDatabaseExample()
        {
            new HelloWorldAPI(WriteToDb).WriteHelloWorld();
        }

        static void WriteToDb(string str)
        {
            //TODO: implement database write
        }


        /// <summary>
        /// return "Hello World!" from the api to any method
        /// </summary>
        /// <returns></returns>
        static string ReturnHelloWorldFromAPI()
        {
            var apiResponse = "";
            new HelloWorldAPI(str => apiResponse = str).WriteHelloWorld();
            return apiResponse;
        }
    }
}
