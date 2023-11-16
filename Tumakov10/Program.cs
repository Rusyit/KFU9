using System;

namespace Tumakov10
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        
            // УПРАЖЕНИЕ 10.1
            Console.WriteLine("УПРАЖНЕНИЕ 10.1.\n");

            Console.WriteLine("Способ шифрования 1");
            Console.Write("Введите строку для шифорвания: ");

            ACipher fMes  = new ACipher(Console.ReadLine());
            fMes.Encode();
            Console.WriteLine($"Зашифрованный вид: {fMes.Mes}");

            fMes.Decode();
            Console.WriteLine($"Расшифрованный вид: {fMes.Mes}");

            Console.WriteLine("\nСпособ шифрования 2");
            Console.Write("Введите строку для шифорвания: ");

            BCipher sMes = new BCipher(Console.ReadLine());
            sMes.Encode();
            Console.WriteLine($"Зашифрованный вид: {sMes.Mes}");

            sMes.Decode();
            Console.WriteLine($"Расшифрованный вид: {sMes.Mes}");


            // ДЩМАШНЕЕ ЗАДАНИЕ 10.1
            Console.WriteLine("ДОМАШНЕЕ ЗАДАНИЕ 10.1.\n");
            Coordinates coord = new Coordinates();
            coord.X = 0;
            coord.Y = 0;
            Point point = new Point(Color.Черный, State.Видимое, coord);
            point.Print();
            point.Vert(11);
            point.Horiz(11);
            point.Print();
            int radius = 11;
            Circle circle = new Circle(Color.Зеленый, State.Видимое, coord, radius);
            circle.Print();
        }
    }
}
