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
            //FirstTaskA();
            //NewClass1.NextTask();
            //FirstTaskB();
            //NewClass1.NextTask();
            //FirstTaskС();
            //NewClass1.NextTask();
            //SecondTask();
            //NewClass1.NextTask();
            ThirdTask();
        }

        public static void FirstTaskA()
        {

            Complex complex1;
            Console.WriteLine("Введите действительную часть первого комплексного числа");
            complex1.re = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть первого комплексного числа");
            complex1.im = Convert.ToDouble(Console.ReadLine());

            Complex complex2;
            Console.WriteLine("Введите действительную часть второго комплексного числа");
            complex2.re = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть второго комплексного числа");
            complex2.im = Convert.ToDouble(Console.ReadLine());

            Complex result = complex1.Minus(complex2);
            Console.WriteLine(result.ToString());
        }

        public static void FirstTaskB()
        {

            ComplexClass complex1 = new ComplexClass();
            Console.WriteLine("Введите действительную часть первого комплексного числа");
            complex1.re = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть первого комплексного числа");
            complex1.im = Convert.ToDouble(Console.ReadLine());

            ComplexClass complex2 = new ComplexClass();
            Console.WriteLine("Введите действительную часть второго комплексного числа");
            complex2.re = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть второго комплексного числа");
            complex2.im = Convert.ToDouble(Console.ReadLine());

            ComplexClass result = complex1.Minus(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());
        }

        public static void FirstTaskС()
        {
            ComplexClass complex1 = new ComplexClass();
            Console.WriteLine("Введите действительную часть первого комплексного числа");
            complex1.re = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть первого комплексного числа");
            complex1.im = Convert.ToDouble(Console.ReadLine());

            ComplexClass complex2 = new ComplexClass();
            Console.WriteLine("Введите действительную часть второго комплексного числа");
            complex2.re = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть второго комплексного числа");
            complex2.im = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Какое действие вы хотите выполнить?(+,-,*)");
            string userTask = (Console.ReadLine());
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

        public static void SecondTask()
        {
            string allNumbers = null;
            int number;
            int i;
            int sum = 0;
            Console.WriteLine("Введите число");
            string b;
            for (i = 0,b = (Console.ReadLine()); b != "0"; i++)
            {
                bool success = Int32.TryParse(b,out number);
                if (success && number>0 && number % 2 > 0)
                {
                    allNumbers = allNumbers + b;
                    sum += number;
                }
                Console.WriteLine("Введите число");
                b = (Console.ReadLine());
            }
            Console.WriteLine($"Нечетные положительные числа: {allNumbers} их сумма: {sum}");
        }

        public static void ThirdTask()
        {

        }
    }

    


    struct Complex
    {
        public double im;
        public double re;
        //  в C# в структурах могут храниться также действия над данными
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        //  Пример произведения двух комплексных чисел
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public override string ToString()
        {
            return re + "+" + im + "i";
        }
    }



    class ComplexClass
    {
        // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
        public double im;
        public double re;

        public ComplexClass Plus(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;
            return x3;
        }

        public ComplexClass Multi(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;
            return x3;
        }

        public ComplexClass Minus(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = this.im - x2.im;
            x3.re = this.re - x2.re;
            return x3;
        }

        public override string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    class DrobClass
    {
        // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
        public double zn;
        public double ch;

        public DrobClass Plus(DrobClass x2)
        {
            DrobClass x3 = new DrobClass();
            x3.zn = x2.zn + this.zn;
            x3.ch = x2.ch + this.ch;
            return x3;
        }

        public DrobClass Multi(DrobClass x2)
        {
            DrobClass x3 = new DrobClass();
            x3.zn = ch * x2.zn + zn * x2.ch;
            x3.ch = ch * x2.ch - zn * x2.zn;
            return x3;
        }

        public DrobClass Minus(DrobClass x2)
        {
            DrobClass x3 = new DrobClass();
            x3.zn = this.zn - x2.zn;
            x3.ch = this.ch - x2.ch;
            return x3;
        }

        public override string ToString()
        {
            return ch + "/" + zn;
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




    //Никогда до этого в своем коде не использовал структуры и классы.  Не помню проходили ли мы их в шараге, но в осознаной практике точно не применял. я как понял это что то наподобии улучшенного массива с удобным доступом?
    //Основное отличие класса как я понял то что его можно доделывать находу т.е. добавлять или убирать его обьекты.
    //Т.е. у себя в играх я могу убрать отдельно лежащие переменные (жизни моба, его пасивки и т.д.) в отдельную структуру, а лучше в класс, что поможет мне легче и быстрее создавать новых, и при желании переходить к старым. так ведь?


}
