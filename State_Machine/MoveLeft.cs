﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Machine
{
    internal class MoveLeft : MovementBaseState
    {
        public override void EnterState()
        {
            Console.WriteLine("You leave the room through the western door.");
        }

        public override void ExitState()
        {
            Console.WriteLine("You have entered the western room.");
        }

        public override IStates CheckState()
        {
            if (Console.KeyAvailable)
            {

                if (Console.ReadKey().Key == ConsoleKey.A)
                {
                    return new IdleState();
                }
            }
            return null;
        }
    }
}
