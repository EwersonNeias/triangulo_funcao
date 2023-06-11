using System;
using System.Globalization;
//Biblioteca usada para o codigo C#
namespace Course
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            // Lê as medidas do triângulo X e armazena em um array
            double[] medidaX = LerMedidasTriangulo("X");

            // Lê as medidas do triângulo Y e armazena em um array
            double[] medidaY = LerMedidasTriangulo("Y");

            // Calcula a área do triângulo X
            double areaX = CalcularAreaTriangulo(medidaX);

            // Calcula a área do triângulo Y
            double areaY = CalcularAreaTriangulo(medidaY);

            // Imprime a área do triângulo X com 4 casas decimais
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));

            // Imprime a área do triângulo Y com 4 casas decimais
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            // Compara as áreas dos triângulos e imprime o maior
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }

        // Função para ler as medidas de um triângulo
        public static double[] LerMedidasTriangulo(string nomeTriangulo)
        {
            double[] medidas = new double[3];

            // Solicita ao usuário para inserir as medidas do triângulo
            Console.WriteLine("Entre com as medidas do triângulo " + nomeTriangulo + ":");

            // Lê as três medidas e armazena no array
            for (int i = 0; i < 3; i++)
            {
                medidas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            return medidas;
        }

        // Função para calcular a área de um triângulo com base nas medidas dos lados
        public static double CalcularAreaTriangulo(double[] medidas)
        {
            // Atribui as medidas dos lados às variáveis a, b e c
            double a = medidas[0];
            double b = medidas[1];
            double c = medidas[2];

            // Calcula o semiperímetro
            double p = (a + b + c) / 2.0;

            // Calcula a área utilizando a fórmula de Heron
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }
    }
}
