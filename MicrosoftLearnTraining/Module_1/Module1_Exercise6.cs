namespace MicrosoftLearnTraining.Module_1
{
    public class Module1_Exercise6
    {
        public void Execute()
        {
            Console.WriteLine("Module 1 - Exercise 6:");

            string nomeDoAluno = "Carlos Silva";
            string nomeCurso1 = "Física 101";
            string nomeCurso2 = "Química 101";
            string nomeCurso3 = "Matemática 102";
            string nomeCurso4 = "História da Arte";
            string nomeCurso5 = "Filosofia 101";

            int creditosCurso1 = 4;
            int creditosCurso2 = 3;
            int creditosCurso3 = 4;
            int creditosCurso4 = 2;
            int creditosCurso5 = 3;

            int notaA = 4;
            int notaB = 3;
            int notaC = 2;

            int notaCurso1 = notaA;
            int notaCurso2 = notaB;
            int notaCurso3 = notaA;
            int notaCurso4 = notaC;
            int notaCurso5 = notaB;

            int totalCreditos = 0;
            totalCreditos += creditosCurso1;
            totalCreditos += creditosCurso2;
            totalCreditos += creditosCurso3;
            totalCreditos += creditosCurso4;
            totalCreditos += creditosCurso5;

            int totalPontos = 0;
            totalPontos += creditosCurso1 * notaCurso1;
            totalPontos += creditosCurso2 * notaCurso2;
            totalPontos += creditosCurso3 * notaCurso3;
            totalPontos += creditosCurso4 * notaCurso4;
            totalPontos += creditosCurso5 * notaCurso5;

            decimal mediaPontos = (decimal)totalPontos / totalCreditos;

            int digitoPrincipal = (int)mediaPontos;
            int primeiroDigito = (int)(mediaPontos * 10) % 10;
            int segundoDigito = (int)(mediaPontos * 100) % 10;

            Console.WriteLine($"Aluno: {nomeDoAluno}\n");
            Console.WriteLine("Curso\t\t\t\tNota\tHoras de Crédito");
            Console.WriteLine($"{nomeCurso1}\t\t\t{notaCurso1}\t\t{creditosCurso1}");
            Console.WriteLine($"{nomeCurso2}\t\t\t{notaCurso2}\t\t{creditosCurso2}");
            Console.WriteLine($"{nomeCurso3}\t\t\t{notaCurso3}\t\t{creditosCurso3}");
            Console.WriteLine($"{nomeCurso4}\t\t\t{notaCurso4}\t\t{creditosCurso4}");
            Console.WriteLine($"{nomeCurso5}\t\t\t{notaCurso5}\t\t{creditosCurso5}");

            Console.WriteLine($"\nMédia Final (GPA):\t\t {digitoPrincipal}.{primeiroDigito}{segundoDigito}");
        }
    }
}
