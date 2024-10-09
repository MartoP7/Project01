using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionWithoutRemainder.Models
{
    public class Division
    {
        List<int> numbers = new List<int>();
        public List<int> Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }

        public double GetP1Value()
        {
            int validNums = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    validNums++;
                }
            }
            return (double)validNums / numbers.Count * 100;
        }
        public double GetP2Value()
        {
            int validNums = 0;
            foreach (int num in numbers)
            {
                if (num % 3 == 0)
                {
                    validNums++;
                }
            }
            return (double)validNums / numbers.Count * 100;
        }
        public double GetP3Value()
        {
            int validNums = 0;
            foreach (int num in numbers)
            {
                if (num % 4 == 0)
                {
                    validNums++;
                }
            }
            return (double)validNums / numbers.Count * 100;
        }
    }
}
