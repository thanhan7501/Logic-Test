using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Test
{
    class Ex05
    {
        public Ex05()
        {
            int [] arr = new int [20];
            int j = 0;
            int n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                arr[j] = n % 10;
                n /= 10;
                j++;
            }
            bool check = true;
            for (int i = 0; i < j; i++)
            {
                if (arr[i] <= arr[i + 1])
                    check = false;
            }
            if (check)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
