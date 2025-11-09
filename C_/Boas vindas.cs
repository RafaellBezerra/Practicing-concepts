namespace C_;

    public class Boas_vindas
    {
        public void BemVindo()
        {
            Console.WriteLine("Qual o seu nome?");
            var nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo! \n");
        }
    }

