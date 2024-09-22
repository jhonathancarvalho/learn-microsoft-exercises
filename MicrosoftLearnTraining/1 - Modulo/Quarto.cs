namespace MicrosoftLearnTraining
{ 
    public class Quarto
    {
        public void Executar()
        {
            int fahrenheit = 94;

            double celsius = (fahrenheit - 32) * 5.0 / 9.0;

            Console.WriteLine($"A temperatura é {celsius:F1} graus Celsius.");

            Console.WriteLine();
        }
    }
}

