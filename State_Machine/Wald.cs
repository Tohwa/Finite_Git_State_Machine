using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Machine
{
    internal class Wald : RoomBaseState
    {
        public override void EnterState()
        {
            Console.WriteLine("Du stehst wie die Axt vorm Wald!");
            Console.WriteLine("Es ist sehr dunkel, Du kannst deine eigene Hand nicht mehr sehen");
        }
        public override IStates CheckState()
        {
            return null;
        }

        public override void UpdateState()
        {
            if (Console.KeyAvailable)
            {

                if (Console.ReadKey().Key == ConsoleKey.F)
                {
                    Console.WriteLine("Du beschwörst eine Taschenlampe!");
                }
            }
           
        }

        public override Void ExitState()
        {
            Console.WriteLine("Du verlässt den Wald!);
        }
    }
}
