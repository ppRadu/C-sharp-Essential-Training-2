using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTraining
{
    public class ProgrammingLoops
    {
        public int ForLoop()
        {
            var sum = 0;

            for(var i = 0; i < 100; i++)
            {
                sum += i;   
            }

            return sum;
        }

        public int ForEachLoop()
        {
            var numbers = new List<int> { 1, 3, 5, 7, 9 };
            var sum = 0;

            foreach(var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        public int WhileLoop()
        {
            var sum = 0;
            var counter = 0;

            while(counter < 100)
            {
                sum += counter;
                counter++;
            }

            return sum;
        }

        public int DoWhileLoop()
        {
            var sum = 0;
            var counter = 0;

            // At least one run through the loop
            // evan if condition starts out false
            do
            {
                sum += counter;
                counter++;
            }
            while (counter < 100);

            return sum;
        }
    }
}
