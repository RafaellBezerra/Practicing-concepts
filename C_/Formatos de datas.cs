namespace C_;
    public class Formatos_de_datas
    {
        public void Datas()
        {
            Console.WriteLine("Escolha um formato de data:");
            Console.WriteLine("1 - Formato completo");
            Console.WriteLine("2 - Apenas a data (dd/mm/yyyy)");
            Console.WriteLine("3 - Apenas a hora");
            Console.WriteLine("4 - Data e mes (por extenso)");
            var data = Console.ReadLine();

            switch (data)
            {
                case "1":
                    Console.WriteLine(DateTime.UtcNow.ToString("R"));
                     break;

                case "2":
                    Console.WriteLine(DateTime.UtcNow.ToString("d"));
                    break;

                case "3":
                    Console.WriteLine(DateTime.UtcNow.ToString("HH"));
                    break;
                    
                case "4":
                    Console.WriteLine(DateTime.UtcNow.ToString("D"));
                    break;

                default: 
                    Console.WriteLine("Escolha uma das opções acima");
                    break;

            }
            Console.ReadKey();
        }
    }

