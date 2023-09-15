using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Machine
{
    internal class MoveUp : MovementBaseState
    {
        public override void EnterState()
        {
            Console.WriteLine("You leave the room through the northern door.");
        }

        public override void ExitState()
        {
            Console.WriteLine("You have entered the northern room.");
        }

        /*
         * public override void UpdateState()
        {
            Console.WriteLine("Ich bin WALKING dead immer noch?");
        }
        */

        public override IStates CheckState()
        {
            if (Console.KeyAvailable)
            {

                if (Console.ReadKey().Key == ConsoleKey.W)
                {
                    return new IdleState();
                }
            }
            return null;
        }
    }
}
