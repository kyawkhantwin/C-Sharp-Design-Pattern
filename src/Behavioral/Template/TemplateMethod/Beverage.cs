using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.Template.TemplateMethod
{
    public abstract class Beverage
    {
        public void MakeBeverage()
        {
            BoilWater();
            Brew();
            PourWater();
            AddCondiments();
        }
        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
        private void PourWater()
        {
            Console.WriteLine("Pouring water");
        }

        protected abstract void Brew();
       
        protected abstract void AddCondiments();

        protected abstract bool CustomerWantsCondiments();
    }
}