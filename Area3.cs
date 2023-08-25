using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diagonal t;
            t = new Diagonal();


            Console.WriteLine("Digite o valor da diagonal");
            t.setd(double.Parse(Console.ReadLine()));
            t.calcular();
            Console.WriteLine("O valor da area {0}", t.geta());




        }
    }
}
