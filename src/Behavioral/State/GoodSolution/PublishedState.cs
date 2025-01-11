using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.State.GoodSolution
{
    public class PublishedState : State
    {
        private Document _document;

        public PublishedState(Document document){
            _document = document;
        }
        public void Publish()
        {
             // nothing
        }
    }
}