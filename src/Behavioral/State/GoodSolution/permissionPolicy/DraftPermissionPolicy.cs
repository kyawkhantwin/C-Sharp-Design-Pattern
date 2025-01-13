using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.State.GoodSolution
{
    public class DraftPermissionPolicy : IPermissionPolicy
    {
        public Boolean CanPublish(UserRoles role)
        {
          if(role != UserRoles.Viewer)  return true;
            return false;
        }
    }
}