using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.Template
{
    public class Tea
    {

        public void MakeBeverage(){
            BoilWater();
            Brew();
            PourWater();
            AddCondiments();
        }
        private void BoilWater(){
            Console.WriteLine("Boiling water");
        }
        private void PourWater(){
            Console.WriteLine("Pouring water");
        }

        private void Brew(){
            Console.WriteLine("Steeping the tea");
        }
        private void AddCondiments(){
            if(CustomerWantsCondiments()){
                Console.WriteLine("Adding lemon");
            }
        }

        private bool CustomerWantsCondiments(){
            Console.WriteLine("Do you want lemon in your tea?(y/n)");
            var answer = Console.ReadLine();

            return answer.ToLower() == "y";
        }


}}