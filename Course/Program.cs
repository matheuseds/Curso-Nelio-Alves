using System;
using System.Globalization;
using System.Threading;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExercEntradaDados();
            //ExercFuncoesMatematicas();
            //ExercTerreno();
            //Exerc1001UriOnline();
            //Exerc1002UriOnline();
            //Exerc1003UriOnline();
            //Exerc1004UriOnline();
            //Exerc1005UriOnline();
            //Exerc1008UriOnline();
            //Exerc1009UriOnline();
            //Exerc10010UriOnline();
            //Exerc10011UriOnline();
            //Exerc10012UriOnline();
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

        public static void ExercTerreno()
        {
            Console.WriteLine("Digite a largura do terreno: ");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a comprimento do terreno: ");
            double comprimento = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do metro quadrado");
            double vlrMetroQuadrado = double.Parse(Console.ReadLine());

            double area = largura * comprimento;
            double preco = area * vlrMetroQuadrado;

            Console.WriteLine($"Área = {area.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Preço = {preco.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static void Exerc1001UriOnline()
        {
            int A, B, X;

            A = int.Parse(Console.ReadLine());

            B = int.Parse(Console.ReadLine());

            X = A + B;

            Console.WriteLine($"X = {X}");
        }

        public static void Exerc1002UriOnline()
        {
            double A;
            double n = 3.14159;
            double raio = double.Parse(Console.ReadLine());

            A = n * Math.Pow(raio, 2);

            Console.WriteLine($"A={A.ToString("F4", CultureInfo.InvariantCulture)}");
        }

        public static void Exerc1003UriOnline()
        {
            int A = int.Parse(Console.ReadLine());

            int B = int.Parse(Console.ReadLine());

            int result = A + B;

            Console.WriteLine($"SOMA = {result}");
        }

        public static void Exerc1004UriOnline()
        {
            int A = int.Parse(Console.ReadLine());

            int B = int.Parse(Console.ReadLine());

            int result = A * B;

            Console.WriteLine($"PROD = {result}");
        }

        public static void Exerc1005UriOnline()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int result = (A * B) - (C * D);

            Console.WriteLine($"DIFERENCA = {result}");
        }

        public static void Exerc1008UriOnline()
        {
            int numFunc = int.Parse(Console.ReadLine());
            int qtdHoras = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = (valorHora * qtdHoras);

            Console.WriteLine($"NUMBER = {numFunc}");
            Console.WriteLine($"SALARY = U$ {result.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static void Exerc1009UriOnline()
        {
            string nome = Console.ReadLine();
            double valorSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = valorSalario + (totalVendas * 0.15);

            Console.WriteLine($"TOTAL = R$ {result.ToString("F2", CultureInfo.InvariantCulture)}");

        }

        public static void Exerc10010UriOnline()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string[] codPeca1 = Console.ReadLine().Split(' ');
            string[] codPeca2 = Console.ReadLine().Split(' ');

            double qtdePeca1 = double.Parse(codPeca1[1]);
            double qtdePeca2 = double.Parse(codPeca2[1]);
            double valorPeca1 = double.Parse(codPeca1[2]);
            double valorPeca2 = double.Parse(codPeca2[2]);

            double result = (qtdePeca1 * valorPeca1) + (qtdePeca2 * valorPeca2);

            Console.WriteLine($"VALOR A PAGAR: R$ {result.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static void Exerc10011UriOnline()
        {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = (4.0 / 3) * 3.14159 * Math.Pow(raio, 3);

            Console.WriteLine($"VOLUME = {result.ToString("F3", CultureInfo.InvariantCulture)}");
        }

        public static void Exerc10012UriOnline()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string[] values = Console.ReadLine().Split(" ");

            double trianguloRet = (double.Parse(values[0]) * double.Parse(values[2])) / 2;
            Console.WriteLine($"TRIANGULO: {trianguloRet.ToString("F3", CultureInfo.InvariantCulture)}");

            double areaCirculo = 3.14159 * Math.Pow(double.Parse(values[2]), 2);
            Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");

            double areaTrapezio = ((double.Parse(values[0]) + double.Parse(values[1])) * double.Parse(values[2])) / 2;
            Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");

            double areaQuadrado = double.Parse(values[1]) * double.Parse(values[1]);
            Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");

            double areaRetangulo = double.Parse(values[0]) * double.Parse(values[1]);
            Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
