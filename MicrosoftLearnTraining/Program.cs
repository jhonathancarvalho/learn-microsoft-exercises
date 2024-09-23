using MicrosoftLearnTraining.Module_1;
using MicrosoftLearnTraining.Module_2;

namespace MicrosoftLearnTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando e executando o primeiro exercício do módulo 1
            var exercise1_module1 = new Module1_Exercise1();
            exercise1_module1.Execute();

            // Instanciando e executando o segundo exercício do módulo 1
            var exercise2_module1 = new Module1_Exercise2();
            exercise2_module1.Execute();

            // Instanciando e executando o terceiro exercício do módulo 1
            var exercise3_module1 = new Module1_Exercise3();
            exercise3_module1.Execute();

            // Instanciando e executando o quarto exercício do módulo 1
            var exercise4_module1 = new Module1_Exercise4();
            exercise4_module1.Execute();

            // Instanciando e executando o quinto exercício do módulo 1
            var exercise5_module1 = new Module1_Exercise5();
            exercise5_module1.Execute();

            // Instanciando e executando o sexto exercício do módulo 1
            var exercise6_module1 = new Module1_Exercise6();
            exercise6_module1.Execute();

            // Instanciando e executando o primeiro exercício do módulo 2
            var exercise1_module2 = new Module2_Exercise1();
            exercise1_module2.Execute();

            // Instanciando e executando o segundo exercício do módulo 2
            var exercise2_module2 = new Module2_Exercise2();
            exercise2_module2.Execute();

            // Instanciando e executando o terceiro exercício do módulo 2
            var exercise3_module2 = new Module2_Exercise3();
            exercise3_module2.Execute();

            // Instanciando e executando o quarto exercício do módulo 2
            var exercise4_module2 = new Module2_Exercise4();
            exercise4_module2.Execute();

            // Instanciando e executando o quinto exercício do módulo 2
            var exercise5_module2 = new Module2_Exercise5();
            exercise5_module2.Execute();

            // Instanciando e executando o sexto exercício do módulo 2
            var exercise6_module2 = new Module2_Exercise6("", new int[0]);
            exercise6_module2.Execute();

            // Instanciando e executando o sétimo exercício do módulo 2
            var exercise7_module2 = new Module2_Exercise7();
            exercise7_module2.Execute();

        }
    }
}
