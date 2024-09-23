namespace MicrosoftLearnTraining.Module_2
{
    public class Module2_Exercise4
    {
        public void Execute()
        {
            Console.WriteLine("Module 2 - Exercise 4:");

            string[] idsPedidos = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            foreach (string idPedido in idsPedidos)
            {
                if (idPedido.StartsWith("B"))
                {
                    Console.WriteLine(idPedido);
                }
            }
            Console.WriteLine();
        }
    }
}
