using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityBinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(9).ToString());
            Console.WriteLine(solution(529).ToString());
            Console.WriteLine(solution(20).ToString());
            Console.WriteLine(solution(15).ToString());
            Console.WriteLine(solution(32).ToString());
            Console.WriteLine(solution(1041).ToString());
            Console.WriteLine(solution(32).ToString());
            Console.ReadLine();
        }

        public static int solution(int N)
        {
            int yedek = 0;
            if (N > 0 && N < 2147483647)
            {
                string binary = Convert.ToString(N, 2);
                if (binary.Count(b => b == '1') < 1 || binary.Count(b => b == '0') < 1)
                    return 0;

                int max = 0;
                foreach (var c in binary)
                {
                    if (c == '1')
                    {
                        if (max >= yedek) yedek = max;
                        max = 0;
                    }
                    else max++;
                }
            }
            return yedek;
        }
    }
}
