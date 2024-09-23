namespace MicrosoftLearnTraining
{ 
    public class Exercise4
    {
        public void Executar()
        {
            Console.WriteLine("Exercise 4:");
           
            int fahrenheit = 94;

            double celsius = (fahrenheit - 32) * 5.0 / 9.0;

            Console.WriteLine($"A temperatura é {celsius:F1} graus Celsius.");

            Console.WriteLine();
        }
    }
}

