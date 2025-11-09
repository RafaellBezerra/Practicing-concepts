namespace C_;

    public class NomeSobrenome
    {
       public void NomeCompleto()
       {
           Console.Write("Digite seu 1º nome: ");
           var nome = Console.ReadLine();
           Console.Write("Digite seu sobrenome : ");
           var sobrenome = Console.ReadLine();

           Console.WriteLine($"{nome + " " + sobrenome} \n");
       }

    }

