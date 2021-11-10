using System;
using Course.Entities.Enums;
namespace Course.Entities
{
    //Herdando a classe Forma
    class Retangulo : Forma
    {      
        //Variáveis
        public double Largura { get; set; }
        public double Altura { get; set; }
        //Encapsulamento
        public Retangulo(double largura, double altura, Color cor) : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }
        //Retorna os valores
        public override double Area()
        {
            return Largura * Altura;
        }
    }
}