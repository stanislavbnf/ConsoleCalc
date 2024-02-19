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
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введите правильный номер");
            }

            else if (number == 1)
            {

                while (true)
                {
                    // Eсли я ввожу десятичные через точку или запятую то цикл начинается с начала, с места где  
                    // просит опять ввести первую цифру. Если числа целые он считает
                   
                    
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Сложение");
                    Console.WriteLine("Введите первое число");

                    string a = Console.ReadLine();
                    a = a.Replace(",", ".");
                    double chislo1;
                    bool usernum1 = double.TryParse(a, out chislo1);




                    Console.WriteLine("Введите второе  число");

                    string b = Console.ReadLine();
                    b = b.Replace(",", ".");
                    double chislo2;
                    bool usernum2 = double.TryParse(b, out chislo2);

                    if (usernum1 && usernum2)

                    {
                        double total;
                        total = Math.Round(chislo1 + chislo2, 12);
                        Console.Clear();
                        Console.WriteLine(chislo1 + "+" + chislo2  + "=" + total);
                        break;
                    }

                    //Также  не работает этот этот else  если ввожу буквы
               
                    else
                    {
                        Console.WriteLine("Недопустимые символы");
                        continue;   
                    }
                }
                

            
            
            
           

            }

            else if (number == 2)
            {
                Console.Clear();
                Console.WriteLine("Вычитание");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Введите первое число");
                string a = Console.ReadLine();
                int chislo1;
                bool usernum1 = int.TryParse(a, out chislo1);


                Console.WriteLine("Введите второе  число");
                string b = Console.ReadLine();
                int chislo2;
                bool usernum2 = int.TryParse(b, out chislo2);

                int total = chislo1 - chislo2;
                Console.Clear();
                Console.WriteLine("ваш результат: " + total);
                continue;
            }
            else if (number == 3)
            {
                Console.Clear();
                Console.WriteLine("Умножение");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Введите первое число");
                string a = Console.ReadLine();
                int chislo1;
                bool usernum1 = int.TryParse(a, out chislo1);


                Console.WriteLine("Введите второе  число");
                string b = Console.ReadLine();
                int chislo2;
                bool usernum2 = int.TryParse(b, out chislo2);

                int total = chislo1 * chislo2;
                Console.Clear();
                Console.WriteLine("ваш результат: " + total);
                continue;
            }

            else if (number == 4)
            {

               
                while (true)
                {


                Console.Clear();
                    Console.WriteLine("Деление");
                    Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Введите первое число");
                string a = Console.ReadLine();
                int chislo1;
                bool usernum1 = int.TryParse(a, out chislo1);


                Console.WriteLine("Введите второе  число");
                string b = Console.ReadLine();
                int chislo2;
                bool usernum2 = int.TryParse(b, out chislo2);


                    if (chislo2 == 0)
                    {
                        Console.WriteLine("Недопустимые символы");
                        continue;
                    }
                    else
                    {

                        double total;
                        total = Math.Round(Convert.ToDouble(chislo1) / Convert.ToDouble(chislo2), 4);

                        Console.Clear();
                        Console.WriteLine("ваш результат: " + total);
                        break;  

                    }
                   
                }
            
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