using System;
using IronPython.Hosting;
using System.IO;

namespace SimplePythonCsharpCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance of python engine
            var engine = Python.CreateEngine();
            //reading code from file
            var source = engine.CreateScriptSourceFromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "simple.py"));
            var scope = engine.CreateScope();
            //executing script in scope
            source.Execute(scope);
            var classCalculator = scope.GetVariable("calculator");
            //initializing class
            var calculatorInstance = engine.Operations.CreateInstance(classCalculator);
            Console.WriteLine("From Iron Python");
            Console.WriteLine("5 + 10 = {0}", calculatorInstance.sum(5, 10));
            Console.WriteLine("5 -10 = {0}", calculatorInstance.sous(5,10));

            Console.ReadLine();
        }
    }
}
