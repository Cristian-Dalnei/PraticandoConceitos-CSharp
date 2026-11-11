namespace PraticandoConceitos.Exercicio004
{
    internal class Exercicio04
    {
        public static void Executar()
        {
            Console.WriteLine("Digite algo: ");
            string entrada = Console.ReadLine();
            int contador = 0;
            for(int i = 0;i < entrada.Length; i++)
            {
                if(entrada[i] == ' ')
                {
                    continue;
                }
                contador++;
            }
            Console.WriteLine($"A string contem {contador} caracteres.");
        }
    }
}
