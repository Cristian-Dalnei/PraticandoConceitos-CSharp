namespace PraticandoConceitos.Exercicio005
{
    internal class Exercicio05
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a placa do veiculo: ");
            string placa = Console.ReadLine();
            bool SeteCaracteres = false;
            bool Letras3Caracteres = false;
            bool Numeros4Caracteres = true;


            if(placa.Length == 7)
            {
                SeteCaracteres = true;
            }
            if (char.IsLetter(placa[0]) && char.IsLetter(placa[1]) && char.IsLetter(placa[2]))
            {
                Letras3Caracteres = true;
            }

            for(int i = 3; i < placa.Length; i++)
            {
                if (!char.IsDigit(placa[i]))
                {
                    Numeros4Caracteres = false;
                    break;
                }
            }

            if(SeteCaracteres && Letras3Caracteres && Numeros4Caracteres)
            {
                Console.WriteLine("Placa valida!");
            }
            else
            {
                Console.WriteLine("Placa Invalida.");
            }
        }
    }
}
