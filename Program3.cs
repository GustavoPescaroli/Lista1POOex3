using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOex1
{
    internal class Diagonal
    {

        private double d;
        private double a;
    

        public void setd(double l)
        {
            d = l;

        }
        public void seta(double l)
        {
            d = l ;

        }

        public double getd()
        {
            return d;
        }

        public double geta()
        {
            return a;
        }

        public void calcular()
        {
            a = Math.Pow(d, 2) /2;
        }


    }

}