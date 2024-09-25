namespace MicrosoftLearnTraining.Module_3
{
    public class Module3_Exercise1
    {
        private string _permission;
        private int _level;

        public Module3_Exercise1(string permission, int level)
        {
            _permission = permission;
            _level = level;
        }

        public Module3_Exercise1()
        {
            _permission = "User";
            _level = 0;
        }

        public void VerificarPermissoes()
        {
            Console.WriteLine("Module 3 - Exercise 1:");

            if (_permission.Contains("Admin"))
            {
                if (_level > 55)
                {
                    Console.WriteLine("Bem-vindo, Super Usuário Admin.");
                }
                else
                {
                    Console.WriteLine("Bem-vindo, Usuário Admin.");
                }
            }
            else if (_permission.Contains("Manager"))
            {
                if (_level >= 20)
                {
                    Console.WriteLine("Contate um Admin para obter acesso.");
                }
                else
                {
                    Console.WriteLine("Você não tem privilégios suficientes.");
                }
            }
            else
            {
                Console.WriteLine("Você não tem privilégios suficientes.");
            }
            Console.WriteLine();
        }
    }
}
