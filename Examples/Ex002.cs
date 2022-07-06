using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yhLee.Examples
{
    public class Ex002
    {
        public void Run()
        {
            Console.WriteLine("숫자를 입력하세요.");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("{0}은 양수인 짝수입니다.", number);
                }

                else
                {
                    Console.WriteLine("{0}은 양수인 홀수입니다.", number);
                }
            }

            else if (number < 0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("{0}은 음수인 짝수입니다.", number);
                }

                else
                {
                    Console.WriteLine("{0}은 음수인 홀수입니다.", number);
                }
            }

            else
            {
                Console.WriteLine("{0}은 zero입니다.", number);
            }


        }
    }
}
