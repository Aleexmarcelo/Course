using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;
using Course.Entities.Enums;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {   //Cria uma lista com quantidade, forma e cor inserida pela usuario
            List<Forma> list = new List<Forma>();
            Console.WriteLine("Entre com o número de formas: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) ;

            Console.WriteLine("Forma: ");
            Console.WriteLine("Retângulo ou Circulo(R / C) ? ");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("Cor: (Preto / Azul / Vermelho): ");
            Color cor = Enum.Parse<Color>(Console.ReadLine());
            //Se digitar R, cria um retangulo
            if (ch == 'R')
            {


                Console.Write("Largura: ");
                double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Altura: ");
                double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Retangulo(largura, altura, cor));
            }
            //Se não, Cria um circulo
            else
            {
                Console.WriteLine("Raio: ");
                double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Circulo(raio, cor));
            }
            //Pede ao usuario para escolher o tamanho da forma
            Console.WriteLine();
            Console.WriteLine("Área de cada forma: ");
            foreach (Forma forma in list)
            {
                Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
