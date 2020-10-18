using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Автор : Пшеничников Максим
/// </summary>
/// 

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTaskA();
            NewClass1.NextTask();
            FirstTaskB();
            NewClass1.NextTask();
            FirstTaskС();
            NewClass1.NextTask();
            SecondTask();
            NewClass1.NextTask();
            ThirdTask();
            NewClass1.NextTask();
        }

        //Задание 1:
        //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
        public static void FirstTaskA()
        {
            // вводим первое комплексное число
            Complex complex1;
            Console.WriteLine("Введите действительную часть первого комплексного числа");
            complex1.re = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть первого комплексного числа");
            complex1.im = Convert.ToDouble(Console.ReadLine());

            // вводим второе комплексное число
            Complex complex2;
            Console.WriteLine("Введите действительную часть второго комплексного числа");
            complex2.re = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть второго комплексного числа");
            complex2.im = Convert.ToDouble(Console.ReadLine());

            // демонстрируем метод вычитания
            Complex result = complex1.Minus(complex2);
            Console.WriteLine(result.ToString());
        }
        
        //Задание 1:
        //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
        public static void FirstTaskB()
        {

            // вводим первое комплексное число
            ComplexClass complex1 = new ComplexClass();
            Console.WriteLine("Введите действительную часть первого комплексного числа");
            complex1.re = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть первого комплексного числа");
            complex1.im = Convert.ToDouble(Console.ReadLine());

            // вводим второе комплексное число
            ComplexClass complex2 = new ComplexClass();
            Console.WriteLine("Введите действительную часть второго комплексного числа");
            complex2.re = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть второго комплексного числа");
            complex2.im = Convert.ToDouble(Console.ReadLine());

            // демонстрируем метод вычитания
            ComplexClass result = complex1.Minus(complex2);
            Console.WriteLine(result.ToString());

            // демонстрируем метод умножения
            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());
        }
        
        //Задание 1:
        //в) Добавить диалог с использованием switch демонстрирующий работу класса.
        public static void FirstTaskС()
        {

            // вводим первое комплексное число
            ComplexClass complex1 = new ComplexClass();
            Console.WriteLine("Введите действительную часть первого комплексного числа");
            complex1.re = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть первого комплексного числа");
            complex1.im = Convert.ToDouble(Console.ReadLine());

            // вводим второе комплексное число
            ComplexClass complex2 = new ComplexClass();
            Console.WriteLine("Введите действительную часть второго комплексного числа");
            complex2.re = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть второго комплексного числа");
            complex2.im = Convert.ToDouble(Console.ReadLine());

            // узнаем какой метод вызвать у пользователя
            Console.WriteLine("Какое действие вы хотите выполнить?(+,-,*)");
            string userTask = (Console.ReadLine());
            
            // вызываем нужный метод
            switch (userTask)
            {
                case "-":
                    ComplexClass result = complex1.Minus(complex2);
                    Console.WriteLine(result.ToString());
                    break;
                case "+":
                    result = complex1.Plus(complex2);
                    Console.WriteLine(result.ToString());
                    break;
                case "*":
                    result = complex1.Multi(complex2);
                    Console.WriteLine(result.ToString());
                    break;
            }
        }

        //Задание 2:
        //а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
        public static void SecondTask()
        {
            // объявляем переменные 
            string allNumbers = null;  // переменная для записи введенных нужных чисел в строку
            int number;  // переменная для вывода из TryParse
            int sum = 0; // переменная для суммы введенных нужных чисел
            string b; // переменная для пользовательских вводимых значений

            // запрашиваем первую строку и начинаем цыкл с проверкой на "0"
            Console.WriteLine("Введите число");
            for (b = (Console.ReadLine()); b != "0";)
            {
                bool success = Int32.TryParse(b, out number);  // проверяем можно ли перевести строку в число
                if (success && number > 0 && number % 2 > 0)  // если перевод удачен и число положительное и нечетное то добавляем его в строку и в общую сумму
                {
                    allNumbers = allNumbers + " " + b;
                    sum += number;
                }
                else  // иначе выводим ошибку
                {
                    Console.WriteLine("Введено некорректные данные, попробуйте еще раз.");
                }

                // запрашиваем новую строку
                Console.WriteLine("Введите число");
                b = (Console.ReadLine());
            }

            // выводим финальную строку и сумму введенных нужных чисел
            Console.WriteLine($"Нечетные положительные числа: {allNumbers} их сумма: {sum}");
        }

        //Задание 3:
        //*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
        public static void ThirdTask()
        {

            // вводим первую дробь
            DrobClass complex1 = new DrobClass();
            Console.WriteLine("Введите числитель первой дроби");
            complex1.ch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель первой дроби");
            complex1.zn = Convert.ToInt32(CheckZn(Convert.ToInt32(Console.ReadLine())));

            // вводим вторую дробь
            DrobClass complex2 = new DrobClass();
            Console.WriteLine("Введите числитель второй дроби");
            complex2.ch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель второй дроби");
            complex2.zn = Convert.ToInt32(CheckZn(Convert.ToInt32(Console.ReadLine())));


            // демонстрируем метод сложения
            DrobClass result = complex1.Plus(complex2);
            Console.WriteLine($"Результат сложения в десятичной дроби: {result.ToDouble()}");
            Console.WriteLine($"Результат сложения: {result.ToString()}");

            // демонстрируем метод вычитания
            result = complex1.Minus(complex2);
            Console.WriteLine($"Результат сложения в десятичной дроби: {result.ToDouble()}");
            Console.WriteLine($"Результат вычитания: {result.ToString()}");

            // демонстрируем метод умножения
            result = complex1.Multi(complex2);
            Console.WriteLine($"Результат сложения в десятичной дроби: {result.ToDouble()}");
            Console.WriteLine($"Результат умножения: {result.ToString()}");

            // демонстрируем метод деления
            result = complex1.Split(complex2);
            Console.WriteLine($"Результат сложения в десятичной дроби: {result.ToDouble()}");
            Console.WriteLine($"Результат деления: {result.ToString()}");
        }

        //Задание 3:
        //** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
        static int CheckZn(int num)
        {
            if (num == 0)
                throw new ArgumentException(String.Format("Знаменатель не может быть равен 0", num), "num");
            return num;
        }
    }



    //Задание 1:
    //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
    struct Complex
    {

        // объявляем переменные 
        public double im; 
        public double re;

        // метод сложения
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        //метод вычитания
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        //  метод произведения
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }

        // метод вывода комплексных чисел
        public override string ToString()
        {
            return re + "+" + im + "i";
        }
    }


    //Задание 1:
    //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
    class ComplexClass
    {
        // объявляем переменные
        public double im;
        public double re;

        // метод сложения
        public ComplexClass Plus(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;
            return x3;
        }

        //  метод произведения
        public ComplexClass Multi(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;
            return x3;
        }

        //метод вычитания
        public ComplexClass Minus(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = this.im - x2.im;
            x3.re = this.re - x2.re;
            return x3;
        }

        // метод вывода комплексных чисел
        public override string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    //Задание 3:
    //*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
    //* Добавить свойства типа int для доступа к числителю и знаменателю;
    //* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
    //*** Добавить упрощение дробей.
    class DrobClass
    {
        // объявляем переменные
        public int zn;  //знаменатель
        public int ch; // чеслитель
        public int ce; //целое
        public double des; //десятичная

        // метод сложения
        public DrobClass Plus(DrobClass x2)
        {
            DrobClass x3 = new DrobClass();
            DrobClass x4 = new DrobClass();
            DrobClass x5 = new DrobClass();
            x4.ch = this.ch * x2.zn;
            x3.zn = this.zn * x2.zn;
            x5.ch = x2.ch * this.zn;
            x3.ch = x4.ch + x5.ch;

            return x3;
        }

        //  метод произведения
        public DrobClass Multi(DrobClass x2)
        {
            DrobClass x3 = new DrobClass();
            x3.ch = this.ch * x2.ch;
            x3.zn = this.zn * x2.zn;
            return x3;
        }

        //метод вычитания
        public DrobClass Minus(DrobClass x2)
        {
            DrobClass x3 = new DrobClass();
            DrobClass x4 = new DrobClass();
            DrobClass x5 = new DrobClass();
            x4.ch = this.ch * x2.zn;
            x3.zn = this.zn * x2.zn;
            x5.ch = x2.ch * this.zn;
            x3.ch = x4.ch - x5.ch;

            return x3;
        }

        //метод деления
        public DrobClass Split(DrobClass x2)
        {
            DrobClass x3 = new DrobClass();
            x3.ch = this.ch * x2.zn;
            x3.zn = this.zn * x2.ch;
            return x3;
        }

        // метод вывода дробных чисел дробью
        public override string ToString()
        {
            if (ch < 0 && zn < 0) // проверка если чеслитель и знаменатель отрицательные то они взаимноуничтожаются
            {
                ch = Math.Abs(ch);
                zn = Math.Abs(zn);
            }
            if (zn<0 && ch>0)  //проверка если только знаменатель отрицательный то минус переходит в чеслитель
            {
                zn = Math.Abs(zn);
                ch *= -1;
            }
            for (int i = 1; i < zn; i++)  // цыкл на упрощение  дроби
            {
                if (zn % i == 0 && ch % i ==0)
                {
                    zn /= i;
                    ch /= i;
                    i = 1;
                }
            }
            while (Math.Abs(ch) >= zn)  // цыкл на выделение целой части 
            {
                if (ch >= 0) // если числитель положительный
                {
                    ch -= zn;
                }
                else
                {
                    ch += zn; // если числитель отрицательный
                }
                ce += 1;
            }
            if (ch == 0) // проверка нужно ли выводить дробную часть
            {
                return Convert.ToString(ce);
            }
            else if (ch < 0) // проверка вынести ли минус за дробь
            {
                ch = Math.Abs(ch);
                ce *= -1;
                return ce + " " + ch + "/" + zn;  // вывод дроби
            }
            else
            {
                return ce + " " + ch + "/" + zn; // вывод дроби вижу что повторение но уже лень править)
            }
        }

        public double ToDouble()  // метод вывода дробных чисел десятичным
        {
            des = (Convert.ToDouble(ch) / Convert.ToDouble(zn));
            //Console.WriteLine($"Это оно: {des}");
            return des;
        }
    }


    public class NewClass1
    {
        public static void NextTask()
        {
            Console.WriteLine("Для перехода к следующему заданию нажмите любую кнопку");
            Console.ReadKey();
            Console.Clear();

        }
    }




    //3е задание оказалось неожиданно сложнее первого из за правильного вывода дробей и работы с отрицательными дробями)
    //но вроде сделал всё правильно)

}
