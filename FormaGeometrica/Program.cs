using System;
using FormaGeometrica.TrianguloRetangulo;
using FormaGeometrica.Retangulo;
using FormaGeometrica.Circulo;
using System.Data;

namespace Programa
{
    public class Atividade
    {
        public static void Main()
        {
            Console.Write("Calculat:\n Triangulo Retangulo = 1 \n Circulo = 2 \n Retangulo = 3");
            int numero = Convert.ToInt32(Console.ReadLine());

            if(numero == 1){
                Console.WriteLine("Digite o numero da base: ");

                TrianguloRetangulo myTriangle = new TrianguloRetangulo {
                    Base = Convert.ToInt32(Console.ReadLine()),
                    Altura = Convert.ToInt32(Console.ReadLine())
                };

                Console.WriteLine($"Area: {myTriangle.Area()}");
                Console.WriteLine($"Perimetro: {myTriangle.Perimetro()}");

            } else if (numero == 2){     
                Console.WriteLine("Digite o numero do Raio: ");

                Circulo myCircle = new Circulo {
                    Raio = Convert.ToInt32(Console.ReadLine())
                };

                Console.WriteLine($"Area: {myCircle.Area()}");
                Console.WriteLine($"Perimetro: {myCircle.Perimetro()}");

            } else if (numero == 3){
                Console.WriteLine("Digite a ALtrure e Base: ");

                Retangulo myRectangle = new Retangulo {
                    Base = Convert.ToInt32(Console.ReadLine()),
                    Altura = Convert.ToInt32(Console.ReadLine())
                };

                Console.WriteLine($"Area: {myRectangle.Area()}");
                Console.WriteLine($"Perimetro: {myRectangle.Perimetro()}");

            } else {
                Console.WriteLine("Digite um numero base para a operação!");
            }
        }
    }
}