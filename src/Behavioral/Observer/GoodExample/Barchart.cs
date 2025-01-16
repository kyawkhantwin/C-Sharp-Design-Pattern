using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.Observer.GoodExample
{
    public class Barchart : Observer
    {
        private DataSource _dataSource;

        public void BarChart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public void Update()
        {
            Console.WriteLine("Rendering Bar chart with new value");
        }
    }
}