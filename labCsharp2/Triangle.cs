using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labCsharp2
{
    class Triangle
    {
        double firstside;
        double secondside;
        double thirdtside;
        string title;
        
        public Triangle()
        {
        }

        public Triangle(double firstside, double secondside, double thirdtside, string title)
        {
            this.title = title;
            Firstside = firstside;
            Secondside = secondside;
            Thirdtside = thirdtside;
        }

        public double Firstside { get => firstside; set => firstside = value >= 0 ? value : 0; }
        public double Secondside { get => secondside; set => secondside = value >= 0 ? value : 0; }
        public double Thirdtside { get => thirdtside; set => thirdtside = value >= 0 ? value : 0; }
        public string Title { get => title; set => title = value; }
        

        override public String ToString()
        {
            if ((Firstside + Secondside > Thirdtside) &&
                    (Secondside + Thirdtside > Firstside) &&
                    (Firstside + Thirdtside > Secondside))
            {
                return this.Title + "Периметр треугольника: " + this.Perimetr() + "\nПлощадь: " + this.Square() + "\nУгол alfa: " + this.Alfa() + "\nУгол beta: " + this.Beta() + "\nУгол gama: " + this.Gama() + "\nСторона а: " + this.firstside + "\nСторона b: " + this.secondside + "\nСторона с: " + this.thirdtside;
            }
            else
                return "Треугольник не существует";
        }

        public double Perimetr()
        {
            return firstside + secondside + thirdtside;     
        }

        public double Square()
        {
            double p, a;
            p = (firstside + secondside + thirdtside) / 2;
            a = Math.Sqrt(p * (p - firstside) * (p - secondside) * (p - thirdtside));
            return a;
        }

        public double Alfa()
        {
            return (180 / Math.PI) * Math.Acos((firstside * firstside - secondside * secondside + thirdtside * thirdtside) / (2 * firstside * thirdtside));
        }
        public double Beta()
        {
            return (180 / Math.PI)*Math.Acos((firstside * firstside + secondside * secondside - thirdtside * thirdtside) / (2 * firstside * secondside));
        }
        public double Gama()
        {
            return (180 / Math.PI) * Math.Acos((secondside * secondside - firstside * firstside + thirdtside * thirdtside) / (2 * secondside * thirdtside));
        }

    } 
}
