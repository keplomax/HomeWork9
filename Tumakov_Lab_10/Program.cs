using System;

namespace Tumakov_Lab_10
{
    internal class Program
    {

        static void Main(string[] args)
        {

            // 10.1 YPR - BCipher 
            Console.WriteLine("УПР 10.1 Создать методы для шифрации сообщений со сдвигом на 1 букву и сдвигом на i букв." +
                "Введите строку. ");
            string encoding = Console.ReadLine();
            ACipher aCipher = new ACipher(encoding);
            Console.WriteLine("Зашифрованная строка:" + aCipher.Encode(encoding));
            Console.WriteLine("Расшифрованная строка:" + aCipher.Decode());
            // 10.1 DZ
            Console.WriteLine("ДЗ 10.1 Создать классы для работы с фигурами.");
            Point point = new Point(5, 10, "Red", true);
            Circle circle = new Circle(3, 6, 5.0, "Blue", true);
            Rectangle rectangle = new Rectangle(1, 2, 4.0, 3.0, "Green", true);

            point.Display();
            Console.WriteLine("Area of Circle: {0}", circle.CalculateArea());
            Console.WriteLine("Area of Rectangle: {0}", rectangle.CalculateArea());

            point.MoveHorizontal(3);
            point.ChangeColor("Yellow");
            point.SetVisible(false);

            circle.MoveVertical(2);
            circle.ChangeColor("Orange");

            rectangle.MoveHorizontal(-1);
            rectangle.MoveVertical(-2);
            rectangle.ChangeColor("Purple");
            rectangle.SetVisible(false);

            Console.WriteLine();
            point.Display();
            circle.Display();
            rectangle.Display();
        }

    }
}
