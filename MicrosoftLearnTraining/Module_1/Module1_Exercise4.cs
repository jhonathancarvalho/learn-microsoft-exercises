namespace MicrosoftLearnTraining.Module_1
{ 
    public class Module1_Exercise4
    {
        public void Execute()
        {
            Console.WriteLine("Module 1 - Exercise 4:");
           
            int fahrenheit = 94;

            double celsius = (fahrenheit - 32) * 5.0 / 9.0;

            Console.WriteLine($"A temperatura é {celsius:F1} graus Celsius.");

            Console.WriteLine();
        }
    }
}

