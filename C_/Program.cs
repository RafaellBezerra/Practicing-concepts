namespace C_;

class Program
{
    static void Main()
    {
        var Exercicio1 = new Boas_vindas();
        Exercicio1.BemVindo();

        var Exercicio2 = new NomeSobrenome();
        Exercicio2.NomeCompleto();

        var Exercicio3 = new Calculos();
        Exercicio3.Operaçoes();

        var Exercicio4 = new QuantidadeCaracteres();
        Exercicio4.Contador();

        var Exercicio5 = new PlacaDoVeiculo();
        Exercicio5.Placa();

        var Exercicio6 = new Formatos_de_datas();
        Exercicio6.Datas();
    }
}
