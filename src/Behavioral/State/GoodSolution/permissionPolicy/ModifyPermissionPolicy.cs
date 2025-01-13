using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.State.GoodSolution.permissionPolicy
{
    public class ModifyPermissionPolicy: IPermissionPolicy
    {
          public Boolean CanPublish(UserRoles role)
        {
             if(role == UserRoles.Admin)  return true;
            return false;
        }
        
    }
}