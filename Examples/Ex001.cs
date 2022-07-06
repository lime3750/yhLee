using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yhLee.Examples
{
    public class Ex001
    {
        public void Run()
        {
            const int zero = 0;

            if (zero == 0)
                Console.WriteLine("첫 번째 if문입니다.");

            if (zero == 0)
            {
                Console.WriteLine("두 번째 if문입니다.");
                Console.WriteLine("zero는 0이기 때문에 출력합니다.");
            }

            if (zero == 1)
                Console.WriteLine("세 번째 if문입니다.");
                Console.WriteLine("zero는 1이 아니기 때문에 출력하지 않습니다.");
        }
    }
}
