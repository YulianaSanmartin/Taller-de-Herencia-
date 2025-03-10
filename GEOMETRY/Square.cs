using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerHerencia
{
    class Square : GeometricFigure

    {
        private double _a;
        public Square(string name, double a) : base(name) => A = a;
        public double A
        {
            get => _a;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("El lado debe ser mayor que 0.");
                _a = value;
            }
        }
        public override double GetArea() => Math.Pow(A, 2);
        public override double GetPerimeter() => 4 * A;
        private void ValidateA(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("El lado debe ser mayor que 0.");
            }
        }
        
    }
}

