namespace C_;

    public class PlacaDoVeiculo
    {
        public void Placa()
        {
            Console.WriteLine("   Placa do Veículo \n");
            Console.Write("Digite suas 3 primeiras letras: ");
            var letras = Console.ReadLine();
            Console.Write("Digite seus 4 ultimos numeros: ");
            var numeros = (Console.ReadLine());

            if (letras!.Length != 3 || numeros!.Length != 4)
                Console.WriteLine(false + "\n");
            else Console.WriteLine($"Placa = {letras + numeros}" + ", " + true + "\n");                
        }
    }

