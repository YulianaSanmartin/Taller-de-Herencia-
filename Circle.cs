using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerHerencia
{
    class Circle : GeometricFigure
    {
        private double _r;
        public Circle(string name, double r) : base(name) => R = r;
        public double R
        {
            get => _r;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("El radio debe ser mayor que 0.");
                _r = value;
            }
        }
        public override double GetArea() => Math.PI * Math.Pow(R, 2);
        public override double GetPerimeter() => 2 * Math.PI * R;
        private void ValidateR(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("El radio debe ser mayor que 0.");
            }
        }
   
    }
}

