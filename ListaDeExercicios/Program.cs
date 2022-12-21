using System;
using System.Globalization;

namespace ListaDeExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema 0 = Soma de 2 numeros

            int x, y;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            Console.WriteLine($"Soma = {x + y}");


            //Problema 1 = Área de um Círculo

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"A = {(3.14159 * Math.Pow(raio, 2)).ToString("F4", CultureInfo.InvariantCulture)}");


            //Problema 2 = Diferença entre Produtos

            int a, b, c, d;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            Console.WriteLine($"Diferença = {(a * b) - (c * d)}");


            //Problema 3 = Salario de um Funcionario

            int funNum, horas;
            double salario;

            funNum = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Número do Funcionario: {funNum}");
            Console.WriteLine($"Salario do Funcionario: R${(horas * salario).ToString("F2", CultureInfo.InvariantCulture)}");


            //Problema 4 = Produto

            string[] prod1 = Console.ReadLine().Split(' ');
            string[] prod2 = Console.ReadLine().Split(' ');

            Console.WriteLine($"Valor a pagar: R${((int.Parse(prod1[1]) * double.Parse(prod1[2], CultureInfo.InvariantCulture)) + (int.Parse(prod2[1]) * double.Parse(prod2[2], CultureInfo.InvariantCulture))).ToString("F2", CultureInfo.InvariantCulture)}");

            //Problema 5 = Área de varias formas
            
            string[] valores = Console.ReadLine().Split(' ');
            double a_, b_, c_;

            a_ = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b_ = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c_ = double.Parse(valores[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"Triângulo: {((a_ * c_) / 2).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Crírculo: {(3.14159 * Math.Pow(c_, 2)).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Trapézio: {(((a_ + b_) * c_) / 2).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Quadrado: {(Math.Pow(b_, 2)).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Retângulo: {(a_ * b_).ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}