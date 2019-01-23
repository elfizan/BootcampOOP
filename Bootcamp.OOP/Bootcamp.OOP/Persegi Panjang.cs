using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.OOP
{
    class Persegi_Panjang : Bangun2D
    {
        private double panjang, lebar;

        public Persegi_Panjang(double p, double l)
        {
            this.panjang = p;
            this.lebar = l;
        }

        public override double HitungLuas()
        {
            return(panjang * lebar);
        }
    }
}
