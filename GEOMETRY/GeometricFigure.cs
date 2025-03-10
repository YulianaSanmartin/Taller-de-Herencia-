using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TallerHerencia
{
    public abstract class GeometricFigure

    {
        public string Name { get; set; }
        public GeometricFigure(string name) => Name = name;
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public override string ToString()
        {
            return $"{Name} => Area.....: {GetArea():F5}  Perimeter: {GetPerimeter():F5}";
        }

    }
}
