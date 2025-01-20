using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.Template
{
    public class Tea
    {
        public void MakeBevrage(){
            
        }
        private void BoilWater(){
            Console.WriteLine("");
        }

        private void PourWaterIntoCup(){
            Console.WriteLine("Pouring water into cup");
        }

        private void Brew(){
            Console.WriteLine("Brewing tea for 3 minutes");
        }

        private void AddCondiments(){
            if(CustomerMantsContiments()){
                Console.WriteLine("Adding Lemon to the tea");
            }
        }
        private bool CustomerMantsContiments(){
            Console.WriteLine("Would you like ltemon with your tea (y/n)");
            string input = Console.ReadLine();

            return input.ToLower() == "y";
        }
    }
}