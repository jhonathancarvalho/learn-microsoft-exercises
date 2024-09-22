namespace MicrosoftLearnTraining
{ 
    public class Exercise5
    {
        public void Executar()
        {
            int totalTrabalhos = 5;

            int ana1 = 93;
            int ana2 = 87;
            int ana3 = 98;
            int ana4 = 95;
            int ana5 = 100;

            int bruno1 = 80;
            int bruno2 = 83;
            int bruno3 = 82;
            int bruno4 = 88;
            int bruno5 = 85;

            int carla1 = 84;
            int carla2 = 96;
            int carla3 = 73;
            int carla4 = 85;
            int carla5 = 79;

            int diego1 = 90;
            int diego2 = 92;
            int diego3 = 98;
            int diego4 = 100;
            int diego5 = 97;

            int anaSoma = ana1 + ana2 + ana3 + ana4 + ana5;
            int brunoSoma = bruno1 + bruno2 + bruno3 + bruno4 + bruno5;
            int carlaSoma = carla1 + carla2 + carla3 + carla4 + carla5;
            int diegoSoma = diego1 + diego2 + diego3 + diego4 + diego5;

            decimal anaNota = (decimal)anaSoma / totalTrabalhos;
            decimal brunoNota = (decimal)brunoSoma / totalTrabalhos;
            decimal carlaNota = (decimal)carlaSoma / totalTrabalhos;
            decimal diegoNota = (decimal)diegoSoma / totalTrabalhos;

            Console.WriteLine("Aluno\t\tNota\n");
            Console.WriteLine($"Ana:\t\t{anaNota:F1}\tA");
            Console.WriteLine($"Bruno:\t\t{brunoNota:F1}\tB");
            Console.WriteLine($"Carla:\t\t{carlaNota:F1}\tB");
            Console.WriteLine($"Diego:\t\t{diegoNota:F1}\tA");

            Console.WriteLine();
        }
    }
}

