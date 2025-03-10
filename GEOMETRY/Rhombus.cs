using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerHerencia
{
    class Rhombus: Square

    {
        private double _d1, _d2;
        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            D1 = d1;
            D2 = d2;
        }
        public double D1
        {
            get => _d1;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("La diagonal D1 debe ser mayor que 0.");
                _d1 = value;
            }
        }
        public double D2
        {
            get => _d2;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("La diagonal D2 debe ser mayor que 0.");
                _d2 = value;
            }
        }
        public override double GetArea() => (D1 * D2) / 2;
        public override double GetPerimeter() => 4 * A;

        private double ValidateD1(double value)
        {
            if (value <= 0)
                throw new ArgumentException("D1 debe ser mayor que 0");
            return value;
        }

        private double ValidateD2(double value)
        {
            if (value <= 0)
                throw new ArgumentException("D2 debe ser mayor que 0");
            return value;
        }
    }
}
  