namespace MicrosoftLearnTraining.Module_3
{
    class Module3_Exercise5
    {
        public void Execute()
        {
            Console.WriteLine("Module 3 - Exercise 5:");

            int valorEntrada;
            bool entradaValida = false;

            Console.WriteLine("Digite um valor inteiro entre 5 e 10:");

            do
            {
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out valorEntrada))
                {
                    if (valorEntrada >= 5 && valorEntrada <= 10)
                    {
                        entradaValida = true; 
                    }
                    else
                    {
                        Console.WriteLine($"{valorEntrada} não está entre 5 e 10. Por favor, tente novamente.");
                    }
                }
                else
                {
                    Console.WriteLine("Desculpe, você inseriu um número inválido. Por favor, tente novamente.");
                }

            } while (!entradaValida); 

            Console.WriteLine($"Seu valor de entrada ({valorEntrada}) foi aceito.");
        }
    }
}
