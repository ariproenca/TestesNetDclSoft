using System;

namespace ConsoleTelecomunicacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a duração da chamada em segundos:");
            int duracaoChamada = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor por minuto(utilize vírgula):");
            double valorMinuto = Convert.ToDouble(Console.ReadLine());

            double valorChamada = CalcularChamada(duracaoChamada, valorMinuto);

            Console.WriteLine("\n");

            Console.WriteLine(valorChamada);
            
            Console.ReadKey();

        }

        public static double CalcularChamada(int duracaoChamada, double valorMinuto)
        {

            int _duracaoChamada = 0;
            double _adicionalChamada = 0;

            if (duracaoChamada <= 60)
            {
                return Convert.ToDouble(valorMinuto);
            }
            else
            {
                _duracaoChamada = duracaoChamada - 60;

                if (_duracaoChamada >= 6)
                {
                    _adicionalChamada = _duracaoChamada / 6;
                }
            }

            return valorMinuto + Convert.ToDouble(_adicionalChamada * 0.01);

        }

    }
}
