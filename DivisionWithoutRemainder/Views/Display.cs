using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionWithoutRemainder.Views
{
    public class Display
    {
        //intput vars
        private List<int> numbers = new List<int>();
        public List<int> Numbers
        { 
            get { return numbers; } 
        }

        //output vars
        private double p1;
        private double p2;
        private double p3;
        public double P3
        {
            get { return p3; }
            set { p3 = value; }
        }
        public double P2
        {
            get { return p2; }
            set { p2 = value; }
        }
        public double P1
        {
            get { return p1; }
            set { p1 = value; }
        }


        public void Input()
        {
            Console.Write("Въведи брой числа: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number >= 0 && number <= 1000)
                {
                    this.numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("! Числото трябва да е в диапазона от 1 до 1000. Въведи ново!");
                    n++;
                }
            }
        }
        public void Output()
        {
            Console.WriteLine($"\nДелят се на 2: {this.p1:f2}%\nДелят се на 3: {this.p2:f2}%\nДелят се на 4: {this.p3:f2}%\n");
        }    
    }
}
