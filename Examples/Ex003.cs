using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yhLee.Examples
{
    public class Ex003
    {
        public void Run()
        {
            Random random = new Random();
            int target_number = random.Next(1, 30);

            Console.WriteLine("1 ~ 30 사이의 숫자를 맞춰보세요.");
            Console.WriteLine("홀짝 힌트: 0 입력");
            Console.WriteLine("범위 힌트: 99 입력");

            int count = 0;
            int answer = 0;
            while ((answer = Convert.ToInt32(Console.ReadLine())) != target_number)
            {
                if (answer == 0)
                {
                    Console.WriteLine("힌트: 숫자는 2로 나누었을 때 나머지가 {0}입니다.", target_number % 2);
                    continue;
                }
                if (answer == 99)
                {
                    if (target_number < 10)
                    {
                        Console.WriteLine("힌트: 10보다 작습니다.");
                    }
                    else if (target_number < 20 && target_number > 10)
                    {
                        Console.WriteLine("힌트: 10보다 크고 20보다 작습니다.");
                    }
                    else
                    {
                        Console.WriteLine("힌트: 20보다 크고 30보다 작습니다.");
                    }
                    continue;
                }
                Console.WriteLine("틀렸어요!");
                count++;
            }
            Console.WriteLine("정답입니다! 맞추기까지 {0}번 소요되었습니다.", count);
        }
    }
}
