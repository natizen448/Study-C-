using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    //abstract class GreetingBase
    //{
    //    public virtual string GetMessage()
    //    {
    //        return "";
    //    }
    //}

    //class GreetingMorning : GreetingBase
    //{
    //    public override string GetMessage()
    //    {
    //        return "GoodMorning";
    //    }
    //}

    //class GreetingAfternoon : GreetingBase
    //{
    //    public override string GetMessage()
    //    {
    //        return "GoodAfternoon";
    //    }
    //}

    //class GreetingEvening : GreetingBase
    //{
    //    public override string GetMessage()
    //    {
    //        return "GoodEvening";
    //    }
    //}


    public class Polymorphism
    {
        static void Main(string[] args)
        {
            //// 다른 형의 객체를 같은것ㅇ로 간주하고 해당 객체의 형에 따라 동작을 전환하는 것
            //// 다시 말해 메서드가 다양한 동작을 할 수 있게 하는 것을 다형성이라고 한다.

            //var greeting = new List<GreetingBase>()
            //{
            //    new GreetingMorning(),
            //    new GreetingAfternoon(),
            //    new GreetingEvening(),
            //};

            
            // 인터페이스를 사용한 다형성

            var greeting = new List<IGreeting>() {
                new GreetingMorning(),
                new GreetingAfternoon(),
                new GreetingEvening(),
            };

            foreach (var obj in greeting)
            {
                string msg = obj.GetMessage();
                Console.WriteLine(msg);
            }
        }
    }

    interface IGreeting
    {
        string GetMessage();
    }


    class GreetingMorning : IGreeting
    {
        public string GetMessage()
        {
            return "GoodMorning";
        }
    }

    class GreetingAfternoon : IGreeting
    {
        public string GetMessage()
        {
            return "GoodAfternoon";
        }
    }

    class GreetingEvening : IGreeting
    {
        public string GetMessage()
        {
            return "GoodEvening";
        }
    }
}
