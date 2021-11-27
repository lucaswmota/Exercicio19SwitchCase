using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio19SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o valor da compra:");
            double compra = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o estado conforme a tabela abaixo:" +
                "\n 1 - SP" +
                "\n 2 - RJ" +
                "\n 3 - DF" +
                "\n 4 - RS" +
                "\n 5 - PR");
            int estado = int.Parse(Console.ReadLine());

            switch (estado)
            {
                case 1:
                    Console.WriteLine("SP - 18% de impostos.");
                    compra += compra * (0.18);

                    Console.WriteLine("O Valor com impostos é de : " + compra.ToString("C"));
                    break;

                case 2:
                    Console.WriteLine("RJ - 16% de impostos.");
                    compra += compra * (0.16);

                    Console.WriteLine("O Valor com impostos é de : " + compra.ToString("C"));
                    break;

                case 3:
                    Console.WriteLine("DF - 15% de impostos.");
                    compra += compra * (0.15);

                    Console.WriteLine("O Valor com impostos é de : " + compra.ToString("C"));
                    break;

                case 4:
                    Console.WriteLine("RS - 12% de impostos.");
                    compra += compra * (0.12);

                    Console.WriteLine("O Valor com impostos é de : " + compra.ToString("C"));
                    break;

                case 5:
                    Console.WriteLine("PR - 10% de impostos.");
                    compra += compra * (0.10);

                    Console.WriteLine("O Valor com impostos é de : " + compra.ToString("C"));
                    break;

                default:
                        Console.WriteLine("Opção inválida");
                        break;
                    
            }
            Console.ReadKey();
        }
    }
}
