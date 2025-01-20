using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.Template.TemplateMethod
{
    public class Coffee : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the Coffee");
        }

        protected override void AddCondiments()
        {
            if (CustomerWantsCondiments())
            {
                Console.WriteLine("Adding cream");
            }
        }

        protected override bool CustomerWantsCondiments()
        {
            Console.WriteLine("Do you want cream in your tea?(y/n)");
            var answer = Console.ReadLine();

            return answer.ToLower() == "y";
        }
    }
}