using Course.Entities.Enums;
namespace Course.Entities
{
    abstract class Forma
    {
        //Método
        public Color Color { get; set; }
        //Construtor das cores
        public Forma(Color color)
        {
            Color = color;
        }
public abstract double Area();
    }
}