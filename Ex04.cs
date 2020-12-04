using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Test
{
    class Ex04
    {
        public Ex04()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while (n > 0)
            {
                int a = n % 10;
                if(a % 2 == 0)
                {
                    count++;
                }
                n = n / 10;
            }

            Console.WriteLine(count);
        }
    }
}
