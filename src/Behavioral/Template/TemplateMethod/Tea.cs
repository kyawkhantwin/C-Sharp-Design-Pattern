using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.Template.TemplateMethod
{
    public class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override void AddCondiments()
        {
            if (CustomerWantsCondiments())
            {
                Console.WriteLine("Adding lemon");
            }
        }

        protected override bool CustomerWantsCondiments()
        {
            Console.WriteLine("Do you want lemon in your tea?(y/n)");
            var answer = Console.ReadLine();

            return answer.ToLower() == "y";
        }

    }
}