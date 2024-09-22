namespace MicrosoftLearnTraining
{
    public class Exercise3
    {
        public void Executar()
        {
            string projectName = "ACME";

            string englishLocation = $@"c:\Exercise\{projectName}\data.txt";

            Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

            string portugueseMessage = "Ver saída em português";

            string portugueseLocation = $@"c:\Exercise\{projectName}\pt-BR\data.txt";

            Console.WriteLine($"{portugueseMessage}:\n\t\t{portugueseLocation}\n");
        }
    }
}
