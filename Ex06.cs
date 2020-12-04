using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Test
{

    class Ex06
    {
        bool Check(int x)
        {
            if (x < 2)
                return false;
            for (int i = 2; i <= (x-1); i++)
                if (x % i == 0)
                    return false;
            return true;
        }

        public Ex06()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> b = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (Check(i) == true)
                {
                    b.Add(i);
                }
            }

            foreach (int a in b)
            {
                Console.WriteLine(a);
            }
        }
    }
}
