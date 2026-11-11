using PraticandoConceitos.Exercicio001;
using PraticandoConceitos.Exercicio002;
using PraticandoConceitos.Exercicio003;
using PraticandoConceitos.Exercicio004;
using PraticandoConceitos.Exercicio005;
using PraticandoConceitos.Exercicio006;

namespace PraticandoConceitos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual exercicio deseja executar:1/2/3/4/5/6/7/8 ");
            int escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    Exercicio01.Executar();
                    break;
                case 2:
                    Exercicio02.Executar();
                    break;
                case 3:
                    Exercicio03.Executar();
                    break;
                case 4:
                    Exercicio04.Executar();
                    break;
                case 5:
                    Exercicio05.Executar();
                    break;
                case 6:
                    Exercicio06.Executar();
                    break;
                default:
                    Console.WriteLine("Valor Invalido.");
                    break;
            }
        }
    }
}
