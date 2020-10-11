using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Автор : Пшеничников Максим
/// </summary>

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
            NewClass1.NextTask();
            SecondTask();
            NewClass1.NextTask();
            ThirdTask();
            NewClass1.NextTask();
            FourthTask();
            NewClass1.NextTask();
            FifthTask();
        }


        //1 Задание: 
        //Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
        //а) используя склеивание;
        //б) используя форматированный вывод;
        //в) используя вывод со знаком $.
        public static void FirstTask()
        {
            Console.WriteLine("Как вас зовут?");
            string firstName = Console.ReadLine();

            Console.WriteLine("Какая у вас Фамилия?");
            string surname = Console.ReadLine();

            Console.WriteLine("Каков ваш возраст?");
            byte age = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Какой у вас рост?");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Какаов ваш вес?");
            double weight = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Имя: " + firstName + ", Фамилия: " + surname + ", Возраст: " + age + ", Рост: " + height + ", Вес: " + weight);  //пункт а
            Console.WriteLine("Имя: {0}, Фамилия: {1}, Возраст: {2}, Рост: {3}, Вес: {4}", firstName, surname, age, height, weight); //пункт б
            Console.WriteLine($"Имя: {firstName}, Фамилия: {surname}, Возраст: {age}, Рост: {height}, Вес: {weight}"); //пункт в
            Console.ReadKey();
        }

        //2 Задание: 
        //Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
        public static void SecondTask()
        {
            Console.WriteLine("Какой у вас рост?");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Какаов ваш вес?");
            double weight = Convert.ToDouble(Console.ReadLine());

            double imt = weight / (height * height);
            Console.WriteLine("ИМТ: " + imt);
            Console.ReadKey();
        }

        //3 Задание: 
        //а)    Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2, y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
        //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
        public static void ThirdTask()
        {
            
            Console.WriteLine("x1?");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("y1?");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("x2?");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("y2?");
            double y2 = Convert.ToDouble(Console.ReadLine());

            DistanceCalculation(x1, y1, x2, y2);
            
        }

        public static void DistanceCalculation(double x1, double y1, double x2, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между точками: {0:f2}", r);
            Console.ReadKey();
        }

        //4 Задание:
        //Написать программу обмена значениями двух переменных:
        //а) с использованием третьей переменной;
        //б) *без использования третьей переменной.
        public static void FourthTask()
        {
            // пункт а
            int a = 10;     
            int b = 20;
            Console.WriteLine("Переменная а: " + a + ", Переменная b: " + b);
            int t = a;        
            a = b;           
            b = t;
            Console.WriteLine("Переменная а: " + a + ", Переменная b: " + b);

            // пункт b
            int c = 10;
            int d = 15;
            Console.WriteLine("Переменная а: " + c + ", Переменная b: " + d);
            c = c - d;
            d = c + d;
            c = -c + d;
            Console.WriteLine("Переменная а: " + c + ", Переменная b: " + d);
            Console.ReadKey();
        }

        //5 Задание:
        //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        //б) *Сделать задание, только вывод организовать в центре экрана.
        //в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x, int y).
        public static void FifthTask()
        {
            Console.WriteLine("Как вас зовут?");
            string firstName = Console.ReadLine();

            Console.WriteLine("Какая у вас Фамилия?");
            string surname = Console.ReadLine();

            Console.WriteLine("Ваш город проживания?");
            string city = Console.ReadLine();

            string text = (firstName + " " + surname + " " + city);
            Print(text);
        }

        public static void Print(string text)
        {
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - text.Length / 2, Console.WindowHeight / 2);
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }

    //6 Задание:
    //*Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
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

