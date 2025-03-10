using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerHerencia
{
    class Triangle : Rectangle

    {
        private double _c;
        private double _h;
        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            C = c;
            H = h;
        }
        public double C
        {
            get => _c;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("El lado C debe ser mayor que 0.");
                _c = value;
            }
        }
        public double H
        {
            get => _h;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("La altura debe ser mayor que 0.");
                _h = value;
            }
        }
        public override double GetArea() => (B * H) / 2;
        public override double GetPerimeter() => A + B + C;
        private double ValidateC(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("El lado C debe ser mayor que 0.");
            }
            return value;
        }

        private double ValidateH(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("La altura debe ser mayor que 0.");
            }
            return value;
        }
    }
}

        