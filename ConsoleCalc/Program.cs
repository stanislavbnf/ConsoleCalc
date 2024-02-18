using System;
using System.ComponentModel.Design;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        while (true)
        {
            Console.WriteLine("Калькулятор:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Выход");

            Console.Write("Выберите операцию (1/2/3/4/5): ");

            string choose = Console.ReadLine();
            int number;
            bool result = int.TryParse(choose, out number);

            if (number == 5)

            {
                Console.Clear();
                Console.WriteLine("Вы вышли из программы");
                break;
            }

            else if (!result)

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введите правильный номер");
            }

            else if (number == 1)
            {
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Введите первое число") ;
                string a = Console.ReadLine();
                int chislo1;
                bool usernum1 = int.TryParse(a, out chislo1);


                Console.WriteLine("Введите второе  число");
                string b = Console.ReadLine();
                int chislo2;
                bool usernum2 = int.TryParse(b, out chislo2);

                int total = chislo1 + chislo2; 
                Console.Clear() ;
                Console.WriteLine("ваш результат: " + total);
                continue;

            }

            else if (number == 2)
            {

            }
            else if (number == 3)
            { 

            }

            else if (number == 4)
            {

            }




            // Код пишем тут
            // Не забываем про break;
            // Не забываем про деление на ноль
            // Не забываем про некорректный ввод (например, буквы)

            //Console.Write("Введите первое число: ");

            //Console.Write("Введите второе число: ");

        }
    }
}