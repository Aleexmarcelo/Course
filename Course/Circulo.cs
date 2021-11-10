using System;
using Course.Entities.Enums;
namespace Course.Entities
{
    //Herdando a classe Forma
    class Circulo : Forma{
        //Variáveis
        public double Raio { get; set; }
        //Encapsulamento
        public Circulo(double raio, Color cor) : base(cor)
    {
        Raio = raio;
    }
        //Retorna os valores
        public override double Area()
    {
        return Math.PI * Raio * Raio;
    }
}
}