using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{   
    
    class Ramda
    {
 
        private void Linq()
        {
            var names = new List<string>
            {
                "Seoul","New Delhi",
            };

            IEnumerable<String> query = names.Where(s => s.Length <= 5).Select(s => s.ToLower()); // Where 메서드를 통해 추출한 문자를 소문자로 변경
                                                                                                  // 이처럼 메서드를 연결하는 것을 메서드 체인이라고 한다.


        }
    }
}
