using System;
using System.Collections.Generic;

namespace CalcLib
{
    public class ProstOperatoin
    {
        public string operation(double a, double b, char op)
        {
            switch (op)
            {
                case '+':
                    return Convert.ToString(a + b);

                case '-':
                    return Convert.ToString(a - b);

                case '*':
                    return Convert.ToString(a * b);

                case '/':
                    if (b != 0)
                        return Convert.ToString(a / b);
                    else
                        return "На нуль дiлити не можна!";

                default:
                    return "Помилка!!";
            }
        }
    }

    public class Korin
    {
        public string operation(double a)
        {
            return Convert.ToString(Math.Sqrt(a));
        }
    }

    public class Stepin
    {
        public string operation(double a, double b)
        {
            return Convert.ToString(Math.Pow(a, b));
        }
    }

    public class Elementy
    {
        public List<string> rez = new List<string>();

        public void PokazRez()
        {
            if (rez.Count == 0)
            {
                Console.WriteLine("Немає результатів.");
            }
            else
            {
                Console.WriteLine("Збережені результати:");
                for (int i = 0; i < rez.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + rez[i]);
                }
            }
        }

        public void YdalRez()
        {
            PokazRez();
            if (rez.Count > 0)
            {
                Console.Write("Введiть номер результату для видалення: ");
                int ind = Convert.ToInt32(Console.ReadLine()) - 1;

                if (ind >= 0 && ind < rez.Count)
                {
                    rez.RemoveAt(ind);
                    Console.WriteLine("Результат видалено.");
                }
                else
                {
                    Console.WriteLine("Неправильний індекс.");
                }
            }
        }

        public void ObnovRez()
        {
            PokazRez();
            if (rez.Count > 0)
            {
                Console.Write("Введiть номер результату для оновлення: ");
                int ind = int.Parse(Console.ReadLine()) - 1;

                if (ind >= 0 && ind < rez.Count)
                {
                    Console.Write("Введiть нове значення: ");
                    string newz = Console.ReadLine();
                    rez[ind] = newz;
                    Console.WriteLine("Результат оновлено.");
                }
                else
                {
                    Console.WriteLine("Неправильний індекс.");
                }
            }
        }
    }
}
