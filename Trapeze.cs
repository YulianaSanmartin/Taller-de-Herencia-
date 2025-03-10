using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerHerencia
{
    class Trapeze : Triangle

    {
        private double _d;
        public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h) => D = d;
        public double D
        {
            get => _d;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("El lado D debe ser mayor que 0.");
                _d = value;
            }
        }
        public override double GetArea() => (B + D) * H / 2;
        public override double GetPerimeter() => A + B + C + D;

        private double ValidateD(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("El lado D debe ser mayor que 0.");
            }
            return value;
        }
    }
}
  
