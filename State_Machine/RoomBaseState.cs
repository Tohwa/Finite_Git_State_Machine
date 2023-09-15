using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Machine
{
    abstract class RoomBaseState : IStates
    {
        public virtual void EnterState()
        {

        }
        public virtual IStates CheckState()
        {
            return null;
        }

        public virtual void UpdateState()
        {

        }

        public virtual void ExitState()
        {

        }

    }
}
