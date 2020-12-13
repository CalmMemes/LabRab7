using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab7
{
    class Class1
    {
        double a, b;
        private Class1() { }
        public Class1(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void Cout()
        {
            Console.WriteLine("Пользователь ввел данные: a = {0}, b = {1}", a, b);

            Console.WriteLine("Интеграл равен: {0}", Integral());

            Console.WriteLine("Длина отрезка: {0:0.000}", LengthSection());
        }
        public void Cout(ConsoleColor fg, ConsoleColor bgs)
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bgs;
            Console.Clear();
            Cout();
        }

        private double Integral()
        {
            double integral = (0.5 * -(Math.Pow(b, 2))) - (0.5 * -(Math.Pow(a, 2)));
            return integral;
        }

        private double LengthSection()
        {
            double dlOtrez = Math.Sqrt(Math.Pow(((-b) - (-a)), 2) + Math.Pow((b - a), 2));
            return dlOtrez;
        }
    }
}
