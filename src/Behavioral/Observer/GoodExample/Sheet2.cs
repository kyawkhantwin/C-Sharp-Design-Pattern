using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.Observer.GoodExample
{
    public class Sheet2 : Observer
    {
        private int _total;
        private Datasource _dataSource;

        public Sheet2(Datasource datasource)
        {
            _dataSource = datasource;
        }

        public int GetToal()
        {
            return _total;
        }


        private int CalculateTotal(List<int> values)
        {
            var sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }
            return sum;
        }

        public void Update()
        {
            _total = CalculateTotal(_dataSource.GetValues());
        }


    }
}