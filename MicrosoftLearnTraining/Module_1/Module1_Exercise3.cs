namespace MicrosoftLearnTraining.Module_1
{
    public class Module1_Exercise3
    {
        public void Execute()
        {
            Console.WriteLine("Module 1 - Exercise 3:");
            
            string projectName = "ACME";

            string englishLocation = $@"c:\Exercise\{projectName}\data.txt";

            Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

            string portugueseMessage = "Ver saída em português";

            string portugueseLocation = $@"c:\Exercise\{projectName}\pt-BR\data.txt";

            Console.WriteLine($"{portugueseMessage}:\n\t\t{portugueseLocation}\n");

            Console.WriteLine();
        }
    }
}
