using System;
using CalcLib;

namespace Calculator_netCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            ProstOperatoin po = new ProstOperatoin();
            Korin kor = new Korin();
            Stepin st = new Stepin();
            Elementy el = new Elementy();

            do
            {
                Console.WriteLine();
                Console.WriteLine("Калькулятор Net .Core");
                Console.WriteLine("1 - Простi операцiї");
                Console.WriteLine("2 - Корiнь числа");
                Console.WriteLine("3 - Пiднесення числа до степеня");
                Console.WriteLine("4 - Показати результати");
                Console.WriteLine("5 - Видалити результат");
                Console.WriteLine("6 - Оновити результат");
                Console.WriteLine("7 - Вихiд");
                Console.WriteLine();
                Console.Write("Введiть номер меню: ");
                n = Console.ReadLine();
                Console.WriteLine();

                switch (n)
                {
                    case "1":
                        Console.Write("Введiть перше число: ");
                        string a = Console.ReadLine();
                        Console.Write("Введiть друге число: ");
                        string b = Console.ReadLine();
                        Console.Write("Введiть операцію (+,-,*,/): ");
                        string op = Console.ReadLine();
                        Console.WriteLine();
                        string rez1 = po.operation(Convert.ToDouble(a), Convert.ToDouble(b), Convert.ToChar(op));
                        Console.WriteLine("Результат: " + rez1);
                        el.rez.Add(rez1);
                        break;

                    case "2":
                        Console.Write("Введiть число, яке хочете поставити пiд корiнь: ");
                        string k = Console.ReadLine();
                        Console.WriteLine();
                        string rez2 = kor.operation(Convert.ToDouble(k));
                        Console.WriteLine("Результат: " + rez2);
                        el.rez.Add(rez2);
                        break;

                    case "3":
                        Console.Write("Введiть число, яке хочете поставити у степiнь: ");
                        string ch = Console.ReadLine();
                        Console.Write("Введiть число, яке буде степенем: ");
                        string stup = Console.ReadLine();
                        Console.WriteLine();
                        string rez3 = st.operation(Convert.ToDouble(ch), Convert.ToDouble(stup));
                        Console.WriteLine("Результат: " + rez3);
                        el.rez.Add(rez3);
                        break;

                    case "4":
                        el.PokazRez();
                        break;

                    case "5":
                        el.YdalRez();
                        break;

                    case "6":
                        el.ObnovRez();
                        break;

                    case "7":
                        break;

                    default:
                        Console.WriteLine("Невірний вибір!");
                        break;
                }

            } while (n != "7");
        }
    }
}
