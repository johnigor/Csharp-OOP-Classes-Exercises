using Herdar_vs_CumprirContrato.Enums;

namespace Herdar_vs_CumprirContrato.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();        
    }
}
