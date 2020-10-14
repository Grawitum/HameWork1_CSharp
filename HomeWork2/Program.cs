using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/// <summary>
/// Автор : Пшеничников Максим
/// </summary>


namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstTask();
            //NewClass1.NextTask();
            //SecondTask();
            //NewClass1.NextTask();
            //ThirdTask();
            //NewClass1.NextTask();
            //FourthTask();
            //NewClass1.NextTask();
            //FifthTask();
            //NewClass1.NextTask();
            SixthTask();
        }

        //1 Задание:
        //Написать метод, возвращающий минимальное из трёх чисел.
        public static void FirstTask()
        {
            Console.WriteLine("Введите первое число");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите третье число?");
            double thirdNumber = Convert.ToDouble(Console.ReadLine());

            if(firstNumber != secondNumber && firstNumber != thirdNumber && secondNumber !=thirdNumber)
            {
                Console.WriteLine($"Минимальное из 3х чисел: {Min(firstNumber, secondNumber, thirdNumber)}");
            }
            else
            {
                Console.WriteLine($"неудалось найти минимального числа");
            }
            

        }

        static double Min(double first, double second, double third)
        {
            if (first < second && first < third) return first;
            if (second < first && second < third) return second;
            if (third < second && third < second) return third;
            return 0;
        }

        //2 Задание:
        //Написать метод подсчета количества цифр числа.
        public static void SecondTask()
        {
            Console.WriteLine("Введите число для подсчета цыфр");
            double numder = Convert.ToDouble(Console.ReadLine());
            int numberOfDigits = 0;
            foreach (char k in numder.ToString())
            {
                numberOfDigits++;
            }
            Console.WriteLine($"Цыфр в числе: {numberOfDigits}");
        }

        //3 Задание:
        //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        public static void ThirdTask()
        {
            double sum =0;
            Console.WriteLine("Введите число");
            double number = Convert.ToDouble(Console.ReadLine());
            while (number != 0)
            {
                if(number >0 && number % 2 > 0)
                {
                    sum = sum + number;
                }
                Console.WriteLine("Введите число");
                number = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine($"Сумма нечетных положительных числе: {sum}");
        }

        //4 Задание:
        //Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
        //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
        //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
        //С помощью цикла do while ограничить ввод пароля тремя попытками.
        public static void FourthTask()
        {
            byte attempts = 0;
            do
                        {
                Console.WriteLine("Введите логин:");
                string login = Console.ReadLine();

                Console.WriteLine("Введите пароль");
                string passworld = Console.ReadLine();

                if (AccessCheck(login, passworld,attempts))
                {
                    break;
                }
                else
                {
                    attempts++;
                }

            } while (attempts <= 2);

            Console.ReadKey();
        }

        static bool AccessCheck(string checkLogin,string checkPassworld,byte attempts)
        {
            string truePassworld = "GeekBrains";
            string trueLogin = "root";

            if (checkLogin == trueLogin && checkPassworld == truePassworld)
            {
                Console.WriteLine($"Доступ открыт");
                return true;
            }
            else if (attempts == 2)
            {
                Console.WriteLine($"Достeg закрыт. Попытки кончились!");
                return false;
            }
            else
            {
                Console.WriteLine($"Доступ закрыт,попробуйте еще раз.");
                return false;
            }
        }

        //5 Задание:
        //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        public static void FifthTask()
        {
            Console.WriteLine("Какой у вас рост?");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Какаов ваш вес?");
            double weight = Convert.ToDouble(Console.ReadLine());

            double imt = weight / (height * height) *10000;
            Console.WriteLine("ИМТ: " + imt);
            if (imt < 18.5)
            {
                Console.WriteLine($"Недобор, нужно набрать : {NormalizeIMT(height, weight, 1)} кг.");
                Console.ReadKey();
            }
            else if(imt > 25)
            {
                Console.WriteLine($"Перебор, нужно похудеть на : {NormalizeIMT(height, weight, -1)} кг.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Норма");
                Console.ReadKey();
            }
            Console.ReadKey();
        }

        static int NormalizeIMT(double height,double weight,int n)
        {
            double imt = 0;
            byte i = 0;
            do
            {
                i++;
                weight = weight + n;
                imt = weight / (height * height) * 10000;
            } while (imt < 18.5 || imt > 25);
            return i;
        }

        //6 Задание:
        //*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр. 
        //Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
        public static void SixthTask()
        {
            long allTime = DateTime.Now.Ticks;
            int goodNumbers = 0;
            for (int i = 1; i < 1000000000; i++)
            {
                int balance = i;
                int SumOfNumbers = 0;
                while (balance > 0)
                {
                    SumOfNumbers += balance % 10;
                    balance /= 10;
                }
                if (i % SumOfNumbers == 0)
                {
                    goodNumbers++;
                }
            }
            Console.WriteLine($"Хороших чисел в диапазоне от 1 до 1000000000 : {goodNumbers} шт.");
            Console.WriteLine($"затрачено времени : {(DateTime.Now.Ticks - allTime)/10000000} сек.");
            Console.ReadKey();
        }

        //7 Задание:
        //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
        //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.



        class NewClass1
        {
            public static void NextTask()
            {
                Console.WriteLine("Для перехода к следующему заданию нажмите любую кнопку");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
    