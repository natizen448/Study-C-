using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class Linq
    {

        private void MethodChaining()
        {
            var names = new List<string>
            {
                "Seoul","New Delhi",
            };

            //IEnumerable<String> query = names.Where(s => s.Length <= 5).Select(s => s.ToLower()); // Where 메서드를 통해 추출한 문자를 소문자로 변경
                                                                                                    // 이처럼 메서드를 연결하는 것을 메서드 체인이라고 한다.

            // 실제 코드에서는 일반적으로 var 키워드를 사용해 다음과 같이 작성한다.
            //var query = names.Where(s => s.Length <= 5).Select(s => s.ToLower());

            // Select만 사용한 예시
            //var query = names.Select(s => s.Length);
            //foreach (var n in query)
            //{
            //    Console.WriteLine("{0} ", n);
            //}


            //// 지연실행
            //var query = names.Where(s => s.Length <= 5);
            //foreach (var item in query)
            //    Console.WriteLine(item);

            //Console.WriteLine("---------");

            //names[0] = "Busan";
            //foreach (var item in query)
            //    Console.WriteLine(item);

            //// 결과
            //// Seoul
            //// Paris
            //// ------
            //// Busan
            //// Paris
            //// 이를 보고 알 수 있는 사실은 이 query 변수에는 검색된결과가 대입되는 것이 아니라, Where 메서드가 호출돼도 검색은 해당 시점에서 실행되지 않고
            //// 실제 값이 필요할 때 쿼리가 실행된다는 것을 나타낸다.
            //// 데이터가 필요할 때마다 쿼리가 실행되는 것이 Linq의 큰 특징이다.
            
        }
    }
}
