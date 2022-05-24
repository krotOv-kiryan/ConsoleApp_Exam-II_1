using System;
using System.Linq;
using System.Threading;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Это задача с экзамена второго курса ППК. лёгкая, но есть два способа решить эту задачу.
            //Вот текст задачи:
            //Вводится 10 чисел не больше байта.
            //Из максимального отнять все введённые и записать этот результат в переменную X.
            //Если X > 0, то ко всем числам прибавляем Х.
            //Если X <= 0, то отнимаем ото всех чисел минимальное.

            // первый вариант - лёгкий, второй более продвинутый
            Console.WriteLine("Здраствуйте. какой метод будем использовать сегодня? первый или второй? ");
            Console.WriteLine("цифра 1 - первый, а цифра 2 - второй метод.");
            double numberMehtod = 0;
            double.TryParse(Console.ReadLine(), out numberMehtod);
            if (numberMehtod == 1)
                FirstMethod();
            else SecondMethod();
        }
        private static void FirstMethod()
        { 
            //тут тупо, но зато работает!!... именно так я решил её на самом экзамене))
            double n1 = 0;
            Console.WriteLine("Введите первое число");
            double.TryParse(Console.ReadLine(), out n1);

            double n2 = 0;
            Console.WriteLine("Введите второе число");
            double.TryParse(Console.ReadLine(), out n2);

            double n3 = 0;
            Console.WriteLine("Введите третье число");
            double.TryParse(Console.ReadLine(), out n3);

            double n4 = 0;
            Console.WriteLine("Введите четвёртое число");
            double.TryParse(Console.ReadLine(), out n4);

            double n5 = 0;
            Console.WriteLine("Введите пятое число");
            double.TryParse(Console.ReadLine(), out n5);

            double n6 = 0;
            Console.WriteLine("Введите шестое число");
            double.TryParse(Console.ReadLine(), out n6);

            double n7 = 0;
            Console.WriteLine("Введите седьмое число");
            double.TryParse(Console.ReadLine(), out n7);

            double n8 = 0;
            Console.WriteLine("Введите восьмое число");
            double.TryParse(Console.ReadLine(), out n8);

            double n9 = 0;
            Console.WriteLine("Введите девятое число");
            double.TryParse(Console.ReadLine(), out n9);

            double n10 = 0;
            Console.WriteLine("Введите десятое число");
            double.TryParse(Console.ReadLine(), out n10);

            //2 часть
            double[] nums = new double[10] { n1, n2, n3, n4, n5, n6, n7, n8, n9, n10 };
            double min = nums.Min();
            double max = nums.Max();
            double summ = nums.Sum();

            double X = 2 * max - summ;
            Console.WriteLine($"");
            //3 часть
            Console.WriteLine($"Сейчас будут расчёты");
            Console.WriteLine($"");
            if (X > 0)
            {
                Console.WriteLine($"Сработало условие X > 0");

                n1 = n1 + X;
                n2 = n2 + X;
                n3 = n3 + X;
                n4 = n4 + X;
                n5 = n5 + X;
                n6 = n6 + X;
                n7 = n7 + X;
                n8 = n8 + X;
                n9 = n9 + X;
                n10 = n10 + X;

                Console.WriteLine($"1 {n1}");
                Console.WriteLine($"2 {n2}");
                Console.WriteLine($"3 {n3}");
                Console.WriteLine($"4 {n4}");
                Console.WriteLine($"1 {n5}");
                Console.WriteLine($"2 {n6}");
                Console.WriteLine($"3 {n7}");
                Console.WriteLine($"4 {n8}");
                Console.WriteLine($"3 {n9}");
                Console.WriteLine($"4 {n10}");
            }
            else if (X <= 0)
            {
                Console.WriteLine($"Сработало условие X <= 0");

                n1 = n1 - min;
                n2 = n2 - min;
                n3 = n3 - min;
                n4 = n4 - min;
                n5 = n5 - min;
                n6 = n6 - min;
                n7 = n7 - min;
                n8 = n8 - min;
                n9 = n9 - min;
                n10 = n10 - min;

                Console.WriteLine($"1 {n1}");
                Console.WriteLine($"2 {n2}");
                Console.WriteLine($"3 {n3}");
                Console.WriteLine($"4 {n4}");
                Console.WriteLine($"1 {n5}");
                Console.WriteLine($"2 {n6}");
                Console.WriteLine($"3 {n7}");
                Console.WriteLine($"4 {n8}");
                Console.WriteLine($"3 {n9}");
                Console.WriteLine($"4 {n10}");
            }
        }
        private static void SecondMethod ()
        {
            //в этом методе я всё решил, кроме того, что число больше байта.
            //char содержит в себе диапазон значений от -128 до 126, при этом 1 байт. но я взял int

            Console.Write("Количество чисел? \t");
            int numsCount = int.Parse(Console.ReadLine());
            if (numsCount < 0 | numsCount > 2147483647)
            {
                Console.WriteLine("ЭЭ ты чё, перезапускай компьютер!"); Thread.Sleep(500);
            }
            Console.WriteLine($"количество введённых чисел: {numsCount}"); Thread.Sleep(500);

            int[] nums = new int[numsCount];
            Console.WriteLine("Вводите числа...");
            for (int i = 0; i < nums.Length; i++) //цикл для ввода numsCount чисел в массив
            {
                Console.Write($"\nЧисло номер {i + 1}:\t");
                nums[i] = int.Parse(Console.ReadLine());
            }

            //2 часть
            int min = nums.Min(); //system Linq
            Console.WriteLine($"\nМинимальное число: {min}");

            int max = nums.Max();
            Console.WriteLine($"Максимальное число:{max}");

            int summ = nums.Sum();
            Console.WriteLine($"Сумма всех чисел:{summ}");
            //Из максимального отнять все введённые и записать этот результат в переменную X.
            int X = 2 * max - summ; // если взять так, чтобы выполнялось не только условие X <= 0, то максимальное умножаем на два.
            //int x = max - summ; // если взять 3, 5, 15 ___ 15 - 3 - 5 - 15 = -8 (так как каждое введённое, там тоже ест ьмаксимальное)
            Console.WriteLine($"новая переменная икс: {X}"); Thread.Sleep(800);

            //3 часть
            Console.WriteLine($"Проверка на условия: X <= 0 или X > 0"); Thread.Sleep(800);

            if (X > 0)//Если X > 0, то ко всем числам прибавляем Х.
            {
                Console.WriteLine($"Сработало условие X > 0"); Thread.Sleep(500);
                Console.WriteLine($"Сейчас будут расчёты"); Thread.Sleep(800);
                int[] arr = nums.Select(s => s + X).ToArray(); Thread.Sleep(800);
                Console.WriteLine($"Вывод всех чисел по итогу:");
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write($"\nЧисло номер {j + 1}:\t {arr[j]}");
                }
                Console.WriteLine($"\nЗадача завершена...");
            }

            else if (X <= 0)   //Если X <= 0, то отнимаем ото всех чисел минимальное.
            {
                Console.WriteLine($"Сработало условие X <= 0");
                Console.WriteLine($"Сейчас будут расчёты"); Thread.Sleep(800);
                int[] arr = nums.Select(s => s + X).ToArray(); Thread.Sleep(800);
                Console.WriteLine($"Вывод всех чисел по итогу:");
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write($"\nЧисло номер {j + 1}:\t {arr[j]}");
                }
                Console.WriteLine($"\nЗадача завершена...");
            }
        }
    }
}
