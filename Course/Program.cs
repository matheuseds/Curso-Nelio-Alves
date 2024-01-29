namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            ExercEntradaDados(); 
        }

        public static void ExercEntradaDados()
        {
            try
            {
                Console.WriteLine("Entre com seu nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Quantos quartos tem na sua casa: ");
                int qtdeQuartos = int.Parse(Console.ReadLine());

                Console.WriteLine("Entre com o preço de um produto: ");
                double vlrprod = double.Parse(Console.ReadLine());

                Console.WriteLine("Entre com seu ultimo nome, idade e altura: ");
                //string[] vet = Console.ReadLine().Split(' ');
                string[] vet = Console.ReadLine().Split(' ');

                Console.WriteLine(nome);
                Console.WriteLine(qtdeQuartos);
                Console.WriteLine(vlrprod);

                Console.WriteLine(vet[0]);
                Console.WriteLine(vet[1]);
                Console.WriteLine(vet[2]);
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
