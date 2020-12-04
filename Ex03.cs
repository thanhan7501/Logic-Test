using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Test
{
    class Ex03
    {
        public Ex03()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            while(n > 0)
            {
                int a = n % 10;
                sum += a;
                n = n / 10;
            }

            Console.WriteLine(sum);
        }
    }
}
