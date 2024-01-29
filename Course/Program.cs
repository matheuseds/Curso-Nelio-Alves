namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            ExercEntradaDados();
            ExercFuncoesMatematicas();
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

        public static void ExercFuncoesMatematicas()
        {
            try
            {
                double x = 3.0;
                double y = 4.0;
                double z = -5.0;

                double resultRaizX = Math.Sqrt(x);
                Console.WriteLine($"Raiz quadrada de 3: {resultRaizX}");

                double resultRaizY = Math.Sqrt(y);
                Console.WriteLine($"Raiz quadrada de 4: {resultRaizY}");

                Console.WriteLine($"Raiz quadrada de 25: {Math.Sqrt(25)}");

                double resultPow = Math.Pow(x, y);
                Console.WriteLine($"{x} elevado a {y}: {resultPow}");

                double resultAbs = Math.Abs(z);
                Console.WriteLine($"Valor absoluto de -5: {resultAbs}");

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
