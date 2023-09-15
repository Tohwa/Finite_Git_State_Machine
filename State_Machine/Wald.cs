using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
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
            Console.Write("Weihnachtsmagier: Oh, Schnellfuß, mein treuer Freund, wir müssen uns beeilen, um die Prinzessin zu retten! Das Schicksal des Königreichs liegt in unseren Händen.\r\n\r\nSchnellfuß: Mit einem mürrischen Blick Aber Meister, ich bin doch eine Schildkröte.Ich kann nicht rennen wie die Pferde des Königs.\r\n\r\nWeihnachtsmagier: Verstehst du nicht, mein lieber Schnellfuß ? Die Zeit ist unser Feind, und wir haben keine Sekunde zu verlieren.Du magst zwar langsam sein, aber du bist klug und tapfer.Gemeinsam werden wir diese Aufgabe bewältigen.\r\n\r\nSchnellfuß: Seufzt Ja, Meister, ich werde mein Bestes geben.Aber ich hoffe, du kannst mich ein wenig schneller machen, zumindest für diese wichtige Mission.\r\n\r\nWeihnachtsmagier: Natürlich, Schnellfuß.Ich werde einen Zauber wirken, der dir ein wenig mehr Geschwindigkeit verleiht.Aber denk daran, es ist nicht nur deine Geschwindigkeit, die zählt.Deine Entschlossenheit und dein Mut sind genauso wichtig.Gemeinsam werden wir die Prinzessin retten und das Königreich vor der Dunkelheit bewahren.\r\n\r\nSchnellfuß: Nickt langsam Verstanden, Meister.Lass uns losziehen und diese Aufgabe erfüllen.");
        }
        public override IStates CheckState()
        {
            if (Console.KeyAvailable)
            {
                if (Console.ReadKey().Key == ConsoleKey.W)
                {
                    return null;
                }
            }
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

        public override void ExitState()
        {
            Console.WriteLine("Du verlässt den Wald!");
        }
    }
}
