using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.State.GoodSolution
{
    public class DraftState : State
    {
        private Document _document;
        private IPermissionPolicy _permissionPolicy;

        public DraftState(Document document)
        {
            _permissionPolicy = new DraftPermissionPolicy();
            _document = document;
        }
        public void Publish()
        {
            if (_permissionPolicy.CanPublish(_document.CurrentUserRole))
            {
                _document.State = new ModerationState(_document);
            }else {
                System.Console.WriteLine(_document.CurrentUserRole + " cannot do this action");
            }
        }




    }
}