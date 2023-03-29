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

                Console.WriteLine("Introduce un número (●'◡'●): ");
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
                        Console.WriteLine("Introduce la base del triángulo: ");
                        triangleB = float.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura del triángulo: ");
                        triangleH = float.Parse(Console.ReadLine());
                        shape = new Triangle(triangleB, triangleH);
                        break;
                    case "2":
                        float radius;
                        Console.WriteLine("Introduce el radio: ");
                        radius = float.Parse(Console.ReadLine());
                        shape = new Circulo(radius);
                        break;
                    case "3":
                        float rectangleB;
                        float rectangleH;
                        Console.WriteLine("Introduce la base del rectángulo: ");
                        rectangleB = float.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura del rectángulo: ");
                        rectangleH = float.Parse(Console.ReadLine());
                        shape = new Rectangulo(rectangleB, rectangleH);
                        break;
                    case "4":
                        float side;
                        Console.WriteLine("Introduce el lado: ");
                        side = float.Parse(Console.ReadLine());
                        shape = new Square(side);
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

                if (shape != null)
                {
                    Console.WriteLine($"El área es {shape.CalculateArea()}");
                }
                Console.WriteLine("dale enter gª: ");
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
