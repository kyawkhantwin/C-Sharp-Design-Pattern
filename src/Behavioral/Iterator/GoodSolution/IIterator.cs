using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.Iterator.GoodSolution
{
    public interface IIterator<T>
    {
        void Next();
        bool HasNext();
        T Current();
    }
}