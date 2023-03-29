using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2jsjs
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueFlag = true;

            while (continueFlag)
            {
                formita shape = null;

                string selection;

                Console.WriteLine("Introduce un número :D: ");
                Console.WriteLine("1. Triángulo");
                Console.WriteLine("2. Círculo");
                Console.WriteLine("3. Rectángulo");
                Console.WriteLine("4. Cuadrado");
                selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        float triangleB;
                        float triangleH;
                        Console.WriteLine("cuanto de base le queres dar al triangulo: ");
                        triangleB = float.Parse(Console.ReadLine());
                        Console.WriteLine("que altura le queres dar al triangulo: ");
                        triangleH = float.Parse(Console.ReadLine());
                        shape = new treslados(triangleB, triangleH);
                        break;
                    case "2":
                        float radius;
                        Console.WriteLine("cuanto de radio le queres dar pa?: ");
                        radius = float.Parse(Console.ReadLine());
                        shape = new Circulo(radius);
                        break;
                    case "3":
                        float rectangleB;
                        float rectangleH;
                        Console.WriteLine("cuanto de base le queres dar al rectangulo: ");
                        rectangleB = float.Parse(Console.ReadLine());
                        Console.WriteLine("que altura le queres dar al rectangulo: ");
                        rectangleH = float.Parse(Console.ReadLine());
                        shape = new Rectangulo(rectangleB, rectangleH);
                        break;
                    case "4":
                        float side;
                        Console.WriteLine("cuanto de lado?: ");
                        side = float.Parse(Console.ReadLine());
                        shape = new cuadraduki(side);
                        break;
                    default:
                        Console.WriteLine("no es valido pa :(");
                        break;
                }

                if (shape != null)
                {
                    Console.WriteLine($"su area es de {shape.CalculateArea()}");
                }
                Console.WriteLine("coloca un si y luego enter pa: ");
                string option = Console.ReadLine();
                if (option != "si")
                {
                    continueFlag = false;
                }
            }
            Console.ReadLine();
        }
    }
}
