namespace MicrosoftLearnTraining.Module_3
{
    public class Module3_Exercise3
    {
        public void ProcessarSku(string sku)
        {
            Console.WriteLine("Module 3 - Exercise 3:");

            string[] produto = sku.Split('-');

            string tipoProduto = "";
            string corProduto = "";
            string tamanhoProduto = "";

            switch (produto[0])
            {
                case "01":
                    tipoProduto = "Moletom";
                    break;
                case "02":
                    tipoProduto = "Camiseta";
                    break;
                case "03":
                    tipoProduto = "Calça de moletom";
                    break;
                default:
                    tipoProduto = "Outro";
                    break;
            }

            switch (produto[1])
            {
                case "BL":
                    corProduto = "Preto";
                    break;
                case "MN":
                    corProduto = "Marrom";
                    break;
                default:
                    corProduto = "Branco";
                    break;
            }

            switch (produto[2])
            {
                case "S":
                    tamanhoProduto = "Pequeno";
                    break;
                case "M":
                    tamanhoProduto = "Médio";
                    break;
                case "L":
                    tamanhoProduto = "Grande";
                    break;
                default:
                    tamanhoProduto = "Tamanho Único";
                    break;
            }

            Console.WriteLine($"Produto: {tamanhoProduto} {corProduto} {tipoProduto}");
        }
    }

}
