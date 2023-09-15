using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Machine
{
    internal class IdleState : MovementBaseState
    {
        public override void EnterState()
        {
            Console.WriteLine("Ich bin jetzt idle!");
        }

        public override void ExitState()
        {
            Console.WriteLine("Ich Bin JETZT nicht mehr IdLe");
        }

        public override void UpdateState()
        {
            Console.WriteLine("Ich bin idle immer noch?");
        }

        public override IStates CheckState()
        {
            if (Console.KeyAvailable)
            {

                if (Console.ReadKey().Key == ConsoleKey.W)
                {
                    return new MoveUp();
                }
            }
            return null;
        }
    }
}
