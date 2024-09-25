namespace MicrosoftLearnTraining.Module_3
{
    public class Module3_Exercise2
    {
        public string ObterSaida()
        {
            Console.WriteLine("Module 3 - Exercise 2:");

            int[] numeros = { 4, 8, 15, 16, 23, 42 };
            int somaTotal = 0;
            bool encontrado = false;

            foreach (int numero in numeros)
            {
                somaTotal += numero;
                if (numero == 42)
                {
                    encontrado = true;
                }
            }

            string saida = string.Empty;

            if (encontrado)
            {
                saida += "Conjunto contém 42\n";
            }

            saida += $"Total: {somaTotal}";

            return saida;

        }
    }
}
