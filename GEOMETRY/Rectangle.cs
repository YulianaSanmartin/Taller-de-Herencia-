using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerHerencia
{
    class Rectangle : Square

    {
        private double _b;
        public Rectangle(string name, double a, double b) : base(name, a) => B = b;
        public double B
        {
            get => _b;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("La base debe ser mayor que 0.");
                _b = value;
            }
        }
        public override double GetArea() => A * B;
        public override double GetPerimeter() => 2 * (A + B);
        private void ValidateB(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("El lado debe ser mayor que 0.");
            }
        }
        
    }

}

