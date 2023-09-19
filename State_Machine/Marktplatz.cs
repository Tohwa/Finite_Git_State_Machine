using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace State_Machine
{
    internal class Marktplatz : RoomBaseState
    {
        //Item1 Brief
        //Item2 Reisekarte
        //Item3 Tascahenlampe
        //Item4 Key
        public override void EnterState()
        {
            TextAnimate("Sitzend am Stadtbrunnen, rechnet Du, unser überzeugungstarker Weihnachtsmagier die Kosten der Geschenke aus.\n" +
                              "Es ist eine kalte Dezembernacht, der Schnee glitzerte im fahlen Licht der Laternen,\n" +
                              "und die Menschen schlendern gemütlich über den beleuchteten Marktplatz. Du der Weihnachtsmagier,\n" +
                              "bekannt für seine magischen Fähigkeiten, hat gerade seinen Tisch mit einer Tischdecke aus funkelndem\n" +
                              "Tannengrün geschmückt und blättert durch einen Stapel Briefe von Kindern, die alle ihre Wünsche an den\n" +
                              "Weihnachtsmann geschickt haben.");
            TextAnimate("\n\nEnter");
            Console.ReadKey(true);
            Console.Clear();
            TextAnimate("Plötzlich findest du einen Brief, der anders ist als die anderen. Es ist ein königlicher Siegelbrief\n" +
                            "mit einer Aufforderung vom König höchstpersönlich.");
            TextAnimate("\n\nEnter");
            Console.ReadKey(true);
            Console.Clear();
            TextAnimate("Willst du den Brief öffnen und ihn lesen?\n");
            TextAnimate("[J]a, [N]ein\n");
            bool FrAnt = false;
            while (FrAnt == false)
            {

                ConsoleKeyInfo input = Console.ReadKey(true);
                Console.Clear();
                switch (input.Key)
                {
                    case ConsoleKey.J:
                        {
                            GameManager.letter = true;
                            FrAnt = true;
                            TextAnimate("Der Brief des Königs:\n");
                            TextAnimate("Euer erhabener Weihnachtsmagier,\r\n\r\n" +
                                            "Mit schwerem Herzen wende ich mich an Euch in diesen finsteren Tagen.\n" +
                                            "Die Dunkelheit hat unser Königreich umhüllt, und unsere Prinzessin ist in den\n" +
                                            "Fängen eines teuflischen Zauberers gefangen, dessen Macht und Bosheit die Grenzen\n" +
                                            "des Verstandes überschreiten.\r\n\r\nNur Ihr, großer Magier, besitzt die Gabe und das Wissen, " +
                                            "diese Bedrohung zu bezwingen.\nDie Freude und das Licht der Weihnachtszeit sind in Gefahr, " +
                                            "und ich flehe Euch an, zu uns zu eilen\nund die Prinzessin zu befreien. Sie ist das Herz " +
                                            "unseres Königreichs und das Strahlen in den Augen unserer Untertanen.\r\n\r\n" +
                                            "Ich weiß, dass die Zeit unser Feind ist, und doch hoffe ich, dass Ihr in Eurer\n" +
                                            "unermüdlichen Güte und Macht die Dunkelheit vertreiben könnt. Ein großzügiger Lohn\n" +
                                            "und der ewige Dank meines Reiches erwarten Euch, wenn Ihr diese Mission erfolgreich beendet.\n" +
                                            "Bitte komme so schnell wie möglich zu meinem Königlichen Schloss\nund hole dir die Karte zum" +
                                            "\r\n\r\nEuer demütiger König, im Angesicht der Dunkelheit und des Glanzes der Weihnachtszeit," +
                                            "\r\nKönig Purzel");
                            TextAnimate("\n\nEnter");
                            Console.ReadKey(true);
                            Console.Clear();
                            break;
                        }

                    case ConsoleKey.N:
                        {
                            FrAnt = true;
                            TextAnimate("Du öffnest also nicht den Brief des Königs und machst stattdessen mit den Briefen der Kinder weiter");
                            TextAnimate("\n\nEnter");
                            Console.ReadKey(true);
                            Console.Clear();
                            TextAnimate("Abends kommst du in deiner kleinen Waldhütte an und verbringst den Abend damit " +
                                "dich zu fragen was der Brief wohl für geheime informationen enthielt");
                            TextAnimate("\n\nEnter");
                            Console.ReadKey(true);
                            Console.Clear();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            TextAnimateTime("Bitte entscheide dich ob du den Brief öffnen willst oder nicht!\n", 1000);
                            FrAnt = false;
                            break;
                        }
                        
                }
            }
            if (GameManager.letter == true)
            {
                TextAnimate("Du schaust erschrocken nach oben, stehst sofort auf und machst dich auf den Weg, der Einladung des Königs nachzukommen");
                TextAnimate("\n\nEnter");
                Console.ReadKey(true);
                Console.Clear();

                TextAnimate("Drücke \"W\" um in das Schloss des Königs zu gelangen");
                TextAnimate("\n\nEnter");
                Console.ReadKey(true);
                Console.Clear();


                Console.Clear();
            }
        }
        public override IStates CheckState()
        {
            if (Console.ReadKey().Key == ConsoleKey.W)
            {
                return new Wald();
            }
            else
            {
                return null;
            }
        }

        public override void UpdateState()
        {

        }

        public override void ExitState()
        {

        }

        public void TextAnimate(string _input)
        {
            if (_input != null || _input != "")
            {

                char[] letters = _input.ToCharArray();
                string output = "";

                for (int i = 0; i < letters.Length; i++)
                {
                    Console.Write(letters[i]);
                    Thread.Sleep(20);
                }
            }

        }

        public void TextAnimateTime(string _input, int _time)
        {
            TextAnimate(_input);
            Thread.Sleep(_time);
            Console.Clear();
        }

    }
}
