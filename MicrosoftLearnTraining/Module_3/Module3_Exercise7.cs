namespace MicrosoftLearnTraining.Module_3
{
    public class Animal
    {
        public int petID { get; set; }
        public string animalNickname { get; set; }
        public string animalPersonalityDescription { get; set; }

        public Animal(int id)
        {
            petID = id;
        }
    }

    public class Module3_Exercise7
    {
        public void Execute()
        {
            Console.WriteLine("Module 3 - Exercise 7:");

            Console.WriteLine("Digite o ID do animal:");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id) || id <= 0)
            {
                Console.WriteLine("Por favor, insira um ID válido (número positivo).");
            }

            Animal animal = new Animal(id);

            if (animal.petID == 0)
            {
                Console.WriteLine("O animal possui um ID padrão e será ignorado.");
                return; 
            }

            Console.WriteLine($"\nDigite um apelido para o ID #: {animal.petID}");
            animal.animalNickname = Console.ReadLine();

            Console.WriteLine($"\nDigite uma descrição de personalidade para o ID #: {animal.petID} (gostos ou desgostos, truques, nível de energia)");
            animal.animalPersonalityDescription = Console.ReadLine();

            Console.WriteLine("\nOs campos de apelido e descrição de personalidade estão completos para o nosso amigo.");
            Console.WriteLine("Pressione a tecla Enter para continuar.");
            Console.ReadLine();
        }
    }
}
