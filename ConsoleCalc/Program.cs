using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Text;

class Program
{
    static void Main()
    {
        var info = CultureInfo.CurrentCulture.Name;
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


                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Сложение");
                    Console.WriteLine("Введите первое число");

                    string a = Console.ReadLine();
                    a = a.Replace(",", ".");
                    double chislo1;
                    bool usernum1 = double.TryParse(a, out chislo1);
                    //bool usernum1 = double.TryParse(a, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out chislo1);




                    Console.WriteLine("Введите второе  число");

                    string b = Console.ReadLine();
                    b = b.Replace(",", ".");
                    double chislo2;
                    bool usernum2 = double.TryParse(b, out chislo2);
                    //bool usernum2 = double.TryParse(b, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out chislo2);

                    if (usernum1 && usernum2)

                    {
                        double total;
                        total = Math.Round(chislo1 + chislo2, 12);
                        Console.Clear();
                        Console.WriteLine(chislo1 + "+" + chislo2 + "=" + total);
                        break;
                    }



                    else
                    {
                        Console.WriteLine("Недопустимые символы");
                        continue;
                    }
                }
            }

            else if (number == 2)
            {
                while (true)
                {


                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Вычитание");
                    Console.WriteLine("Введите первое число");

                    string a = Console.ReadLine();
                    a = a.Replace(",", ".");
                    double chislo1;
                    bool usernum1 = double.TryParse(a, out chislo1);
                    //bool usernum1 = double.TryParse(a, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out chislo1);




                    Console.WriteLine("Введите второе  число");

                    string b = Console.ReadLine();
                    b = b.Replace(",", ".");
                    double chislo2;
                    bool usernum2 = double.TryParse(b, out chislo2);
                    //bool usernum2 = double.TryParse(b, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out chislo2);

                    if (usernum1 && usernum2)

                    {
                        double total;
                        total = Math.Round(chislo1 - chislo2, 12);
                        Console.Clear();
                        Console.WriteLine(chislo1 + "-" + chislo2 + "=" + total);
                        break;
                    }



                    else
                    {
                        Console.WriteLine("Недопустимые символы");
                        continue;
                    }
                }
            }


            else if (number == 3)
            {
                while (true)
                {


                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Умножение");
                    Console.WriteLine("Введите первое число");

                    string a = Console.ReadLine();
                    a = a.Replace(",", ".");
                    double chislo1;
                    bool usernum1 = double.TryParse(a, out chislo1);
                    //bool usernum1 = double.TryParse(a, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out chislo1);




                    Console.WriteLine("Введите второе  число");

                    string b = Console.ReadLine();
                    b = b.Replace(",", ".");
                    double chislo2;
                    bool usernum2 = double.TryParse(b, out chislo2);
                    //bool usernum2 = double.TryParse(b, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out chislo2);

                    if (usernum1 && usernum2)

                    {
                        double total;
                        total = Math.Round(chislo1 * chislo2, 12);
                        Console.Clear();
                        Console.WriteLine(chislo1 + "*" + chislo2 + "=" + total);
                        break;
                    }



                    else
                    {
                        Console.WriteLine("Недопустимые символы");
                        continue;
                    }
                }
            }

            else if (number == 4)
            {


                while (true)
                {


                    
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Деление");
                  

                    Console.WriteLine("Введите первое число");
                    string a = Console.ReadLine();
                    double chislo1;
                    bool usernum1 = double.TryParse(a, out chislo1);


                    Console.WriteLine("Введите второе  число");
                    string b = Console.ReadLine();
                    double chislo2;
                    bool usernum2 = double.TryParse(b, out chislo2);


                    if (chislo2 == 0)
                    {
                        Console.WriteLine("Недопустимые символы");
                        continue;
                    }

                    else if (usernum1 && usernum2)

                    {
                        double total;
                        total = Math.Round(chislo1 / chislo2, 12);
                        Console.Clear();
                        Console.WriteLine(chislo1 + "/" + chislo2 + "=" + total);
                        break;
                    }

                    //else
                    //{

                    //    double total;
                    //    total = Math.Round(Convert.ToDouble(chislo1) / Convert.ToDouble(chislo2), 4);

                    //    Console.Clear();
                    //    Console.WriteLine("ваш результат: " + total);
                    //    break;

                    //}

                }

            }

            else if (number <= 0)

            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введите правильный номер");
            }

            else if (number >=6)

            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введите правильный номер");
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