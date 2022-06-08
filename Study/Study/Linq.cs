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

            // IEnumerable<String> query = names.Where(s => s.Length <= 5).Select(s => s.ToLower()); // Where 메서드를 통해 추출한 문자를 소문자로 변경
            // 이처럼 메서드를 연결하는 것을 메서드 체인이라고 한다.

            // 실제 코드에서는 일반적으로 var 키워드를 사용해 다음과 같이 작성한다.
            //var query = names.Where(s => s.Length <= 5).Select(s => s.ToLower());

            // Select만 사용한 예시
            var query = names.Select(s => s.Length);
            foreach (var n in query)
            {
                Console.WriteLine("{0} ", n);
            }
        }
    }
}
