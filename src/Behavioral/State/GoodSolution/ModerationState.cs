using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesginPattern.src.Behavioral.State.GoodSolution.permissionPolicy;

namespace DesginPattern.src.Behavioral.State.GoodSolution
{
    public class ModerationState: State
    {
        private Document _document;
        private IPermissionPolicy _permissionPolicy;
        
        public ModerationState(Document document){
            _permissionPolicy = new ModifyPermissionPolicy();
            _document = document;
        }
        public void Publish()
        {
            if (_permissionPolicy.CanPublish(_document.CurrentUserRole))
            {
                _document.State = new PublishedState(_document);
            }else {
                System.Console.WriteLine(_document.CurrentUserRole + " cannot do this action");
            }
        }        
    
    }
}