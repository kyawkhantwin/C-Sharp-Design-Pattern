using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.Template.StrategyPattern
{
    public class Coffee : Beverage
    {
        public void Perpare()
        {
            Brew();
            AddCondiments();
        }
          private void Brew(){
            Console.WriteLine("Steeping the Coffee");
        }
        private void AddCondiments(){
            if(CustomerWantsCondiments()){
                Console.WriteLine("Adding cream");
            }
        }

        private bool CustomerWantsCondiments(){
            Console.WriteLine("Do you want cream in your tea?(y/n)");
            var answer = Console.ReadLine();

            return answer.ToLower() == "y";
        }
    }
}