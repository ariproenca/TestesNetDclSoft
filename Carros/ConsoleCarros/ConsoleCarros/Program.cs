using System;

namespace ConsoleCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de carros vendidos:");
            int numeroCarrosVendidos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor total das suas vendas:");
            double valorTotalVendas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do salário fixo:");
            double valorSalarioFixo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a comissão fixa por cada carro vendido:");
            double valorComissaoCarroVendido = Convert.ToDouble(Console.ReadLine());

            double salarioFinalVendedor = CalcularSalarioFinalVendedor(valorSalarioFixo, valorComissaoCarroVendido, numeroCarrosVendidos, valorTotalVendas);

            Console.WriteLine("\n");

            Console.WriteLine(salarioFinalVendedor);
            Console.ReadKey();
            
        }

        public static double CalcularSalarioFinalVendedor( double salarioFixoVendedor,
                                                    double valorComissaoCarroVendido,
                                                    int numeroCarrosVendidos,
                                                    double valorTotalVendas)
        {
            double totalValorComissaoCarroVendido = Convert.ToDouble(valorComissaoCarroVendido * numeroCarrosVendidos);

            return Convert.ToDouble(salarioFixoVendedor + totalValorComissaoCarroVendido + (Convert.ToDouble(valorTotalVendas * 1.05)));
        }

    }
}
