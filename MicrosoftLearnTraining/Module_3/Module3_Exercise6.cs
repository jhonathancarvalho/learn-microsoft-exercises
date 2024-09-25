namespace MicrosoftLearnTraining.Module_3
{
    using System;

    namespace CsharpProjects
    {
        class Module3_Exercise6
        {
            public struct Animal
            {
                public string petID;
                public string especie;
                public int idade;
                public string descricaoFisica;
                public string descricaoPersonalidade;
                public string apelido;
            }

            public void Execute()
            {
                Console.WriteLine("Module 3 - Exercise 6:");

                const int maxPets = 10;
                Animal[] ourAnimals = new Animal[maxPets];
                int petCount = 0;
                string readResult;
                bool anotherPet = true;

                while (anotherPet && petCount < maxPets)
                {
                    bool validEntry = false;
                    string animalSpecies = "";

                    do
                    {
                        Console.WriteLine("\nDigite 'cão' ou 'gato' para iniciar uma nova entrada:");
                        readResult = Console.ReadLine();

                        if (readResult != null)
                        {
                            animalSpecies = readResult.ToLower();
                            if (animalSpecies != "cão" && animalSpecies != "gato")
                            {
                                validEntry = false;
                                Console.WriteLine("Espécie inválida. Tente novamente.");
                            }
                            else
                            {
                                validEntry = true;
                            }
                        }

                    } while (!validEntry);

                    string petID = $"{animalSpecies}_{petCount + 1}";

                    int idade = 0;
                    validEntry = false;

                    do
                    {
                        Console.WriteLine("Digite a idade do animal de estimação (número inteiro):");
                        readResult = Console.ReadLine();
                        if (int.TryParse(readResult, out idade) && idade > 0)
                        {
                            validEntry = true;
                        }
                        else
                        {
                            Console.WriteLine("Idade inválida. Por favor, insira um número inteiro positivo.");
                        }
                    } while (!validEntry);

                    Console.WriteLine("Digite a descrição física do animal de estimação:");
                    string descricaoFisica = Console.ReadLine();

                    Console.WriteLine("Digite a descrição da personalidade do animal de estimação:");
                    string descricaoPersonalidade = Console.ReadLine();

                    string apelido = "";
                    validEntry = false;

                    do
                    {
                        Console.WriteLine("Digite o apelido do animal de estimação:");
                        readResult = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(readResult))
                        {
                            apelido = readResult;
                            validEntry = true;
                        }
                        else
                        {
                            Console.WriteLine("Apelido inválido. Por favor, insira um apelido.");
                        }

                    } while (!validEntry);

                    ourAnimals[petCount] = new Animal
                    {
                        petID = petID,
                        especie = animalSpecies,
                        idade = idade,
                        descricaoFisica = descricaoFisica,
                        descricaoPersonalidade = descricaoPersonalidade,
                        apelido = apelido
                    };

                    petCount++;

                    if (petCount < maxPets)
                    {
                        Console.WriteLine("Deseja adicionar outro animal? (y/n)");
                        readResult = Console.ReadLine();
                        anotherPet = readResult != null && readResult.ToLower() == "y";
                    }
                    else
                    {
                        anotherPet = false;
                    }
                }

                Console.WriteLine("\nAnimais cadastrados:");
                for (int i = 0; i < petCount; i++)
                {
                    Console.WriteLine($"ID: {ourAnimals[i].petID}, Espécie: {ourAnimals[i].especie}, Idade: {ourAnimals[i].idade}, " +
                        $"Descrição Física: {ourAnimals[i].descricaoFisica}, Descrição da Personalidade: {ourAnimals[i].descricaoPersonalidade}, " +
                        $"Apelido: {ourAnimals[i].apelido}");
                }
            }
        }

    }

}
