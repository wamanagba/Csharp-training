using RDotNet;
using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        // R session initialization 
        REngine.SetEnvironmentVariables();
        REngine engine = REngine.GetInstance();

        // Read R code from a file
        string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "script.R");
        string script = File.ReadAllText(scriptPath);

        // Running the R code
        engine.Evaluate(script);

        // Call the 'mean' function from R code named Calcul
        NumericVector vector = engine.Evaluate("Calcul(c(1, 2, 3, 4, 5))").AsNumeric();

        // Recovery of return value
        double mean = vector[0];

        // Display of calculated average
        Console.WriteLine("La moyenne est : " + mean);
        Console.ReadLine();
        // Cleaning the R session
        engine.Dispose();
    }
}
