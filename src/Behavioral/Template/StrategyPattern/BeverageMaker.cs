using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesginPattern.src.Behavioral.Template.StrategyPattern;

namespace DesginPattern.src.Behavioral.Template
{
    public class BeverageMaker
    {
        private Beverage _beverage;
        public BeverageMaker(Beverage beverage)
        {
            _beverage = beverage;
        }

        public void ChangeBeverage(Beverage beverage)
        {
            _beverage = beverage;
        }

        public void MakeBeverage()
        {
            BoilWater();
            PourWater();
            _beverage.Perpare();

        }
        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
        private void PourWater()
        {
            Console.WriteLine("Pouring water");
        }


    }
}