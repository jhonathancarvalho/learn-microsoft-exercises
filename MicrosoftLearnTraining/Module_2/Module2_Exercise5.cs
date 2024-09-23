namespace MicrosoftLearnTraining.Module_2
{
    public class Module2_Exercise5
    {
        public void Execute()
        {
            Console.WriteLine("Module 2 - Exercise 5:");

            string mensagemOriginal = "The quick brown fox jumps over the lazy dog.";

            char[] arrayCaracteres = mensagemOriginal.ToCharArray();

            Array.Reverse(arrayCaracteres);

            int contagemO = 0;
            foreach (char caracter in arrayCaracteres)
            {
                if (caracter == 'o')
                {
                    contagemO++;
                }
            }

            string mensagemInvertida = new string(arrayCaracteres);

            Console.WriteLine(mensagemInvertida);
            Console.WriteLine($"'o' aparece {contagemO} vezes.");
            Console.WriteLine();
        }
    }
}
