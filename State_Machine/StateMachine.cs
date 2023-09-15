using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Machine
{
    internal class StateMachine
    {
        private IStates curState;

        public void Start()
        {
            curState = new IdleState();
            curState.EnterState();
        }

        public void Update()
        {
            IStates newState;
            newState = curState.CheckState();

            if(newState != null)
            {
                curState.ExitState();
                curState = newState;
                curState.EnterState();
            }

            curState.UpdateState();
        }
    }
}
