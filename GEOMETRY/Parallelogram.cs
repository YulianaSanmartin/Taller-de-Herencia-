using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerHerencia
{
    class Parallelogram : Rectangle
    {
        private double _h;
        public Parallelogram(string name, double a, double b, double h) : base(name, a, b) => H = h;
        public double H
        {
            get => _h;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("La altura debe ser mayor que 0.");
                _h = value;
            }
        }
        public override double GetArea() => B * H;
        public override double GetPerimeter() => 2 * (A + B);
        private void ValidateH(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("La altura debe ser mayor que 0.");
            }
        }
       
    }
}

