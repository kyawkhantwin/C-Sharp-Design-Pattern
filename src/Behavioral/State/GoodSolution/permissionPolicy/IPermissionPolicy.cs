using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.State.GoodSolution
{
    public interface IPermissionPolicy
    {
        Boolean CanPublish(UserRoles role);
    }
}