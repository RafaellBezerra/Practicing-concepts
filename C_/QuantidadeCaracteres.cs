namespace C_;

    public class QuantidadeCaracteres
    {
        public void Contador()
        {
            Console.WriteLine("  Contador de Caracteres \n");
            Console.Write("Digite uma ou mais palavras: ");
            var palavras = Console.ReadLine();

            Console.WriteLine(palavras!.Replace(" ","").Length + "\n");
        }
    }

