using System;
using System.Collections.Generic;
using System.Text;

namespace PraticandoConceitos.Exercicio003
{
    internal class Exercicio03
    {
        public static void Executar()
        {
            double x;
            double y;
            do
            {
                Console.WriteLine("Digite um numero x: ");
                x = Double.Parse(Console.ReadLine());
                Console.WriteLine("Digite um numero y: ");
                y = Double.Parse(Console.ReadLine());

            } while (y < 0);
            double soma = x + y;
            double subtracao = x - y;
            double multiplicacao = x * y;
            double divisao = x/y;
            double media = soma / 2;
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Ssubtração: {subtracao}");
            Console.WriteLine($"Multiplicação: {multiplicacao}");
            Console.WriteLine($"Divisão: {divisao}");
            Console.WriteLine($"Media: {media}");
        }
    }
}
