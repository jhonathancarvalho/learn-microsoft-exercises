namespace MicrosoftLearnTraining.Module_2
{
    public class Module2_Exercise3
    {
        public void Execute()
        {
            Console.WriteLine("Module 2 - Exercise 3:");

            Random aleatorio = new Random();
            int diasAteExpiracao = aleatorio.Next(12);
            int porcentagemDesconto = 0;

            if (diasAteExpiracao == 0)
            {
                Console.WriteLine("Sua assinatura expirou.");
            }
            else if (diasAteExpiracao == 1)
            {
                porcentagemDesconto = 20;
                Console.WriteLine("Sua assinatura expira em menos de um dia!");
                Console.WriteLine($"Renove agora e economize {porcentagemDesconto}%!");
            }
            else if (diasAteExpiracao <= 5)
            {
                porcentagemDesconto = 10;
                Console.WriteLine($"Sua assinatura expira em {diasAteExpiracao} dias.");
                Console.WriteLine($"Renove agora e economize {porcentagemDesconto}%!");
            }
            else if (diasAteExpiracao <= 10)
            {
                Console.WriteLine("Sua assinatura vai expirar em breve. Renove agora!");
            }
            Console.WriteLine();
        }
    }
}
