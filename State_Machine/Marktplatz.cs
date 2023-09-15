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
        public static GameManager GameManager = new GameManager();
        //Item1 Brief
        //Item2 Reisekarte
        //Item3 Tascahenlampe
        //Item4 Key
        public override void EnterState()
        {
            TextAnimateTime("Sitzend am Stadtbrunnen, rechnet Du, unser überzeugungstarker Weihnachtsmagier die Kosten der Geschenke aus. " +
                              "Es ist eine kalte Dezembernacht, der Schnee glitzerte im fahlen Licht der Laternen, " +
                              "und die Menschen schlendern gemütlich über den beleuchteten Marktplatz. Du der Weihnachtsmagier, " +
                              "bekannt für seine magischen Fähigkeiten, hat gerade seinen Tisch mit einer Tischdecke aus funkelndem " +
                              "Tannengrün geschmückt und blättert durch einen Stapel Briefe von Kindern, die alle ihre Wünsche an den " +
                              "Weihnachtsmann geschickt haben.",1000);
            TextAnimateTime("Plötzlich findest du einen Brief, der anders ist als die anderen. Es ist ein königlicher Siegelbrief " +
                            "mit einer Aufforderung vom König höchstpersönlich.",1000);

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
                            GameManager.item1 = true;
                            TextAnimate("Der Brief des Königs:\n");
                            TextAnimateTime("Euer erhabener Weihnachtsmagier,\r\n\r\n" +
                                            "Mit schwerem Herzen wende ich mich an Euch in diesen finsteren Tagen. " +
                                            "Die Dunkelheit hat unser Königreich umhüllt, und unsere Prinzessin ist in den " +
                                            "Fängen eines teuflischen Zauberers gefangen, dessen Macht und Bosheit die Grenzen " +
                                            "des Verstandes überschreiten.\r\n\r\nNur Ihr, großer Magier, besitzt die Gabe und das Wissen, " +
                                            "diese Bedrohung zu bezwingen. Die Freude und das Licht der Weihnachtszeit sind in Gefahr, " +
                                            "und ich flehe Euch an, zu uns zu eilen und die Prinzessin zu befreien. Sie ist das Herz " +
                                            "unseres Königreichs und das Strahlen in den Augen unserer Untertanen.\r\n\r\n" +
                                            "Ich weiß, dass die Zeit unser Feind ist, und doch hoffe ich, dass Ihr in Eurer " +
                                            "unermüdlichen Güte und Macht die Dunkelheit vertreiben könnt. Ein großzügiger Lohn " +
                                            "und der ewige Dank meines Reiches erwarten Euch, wenn Ihr diese Mission erfolgreich beendet. " +
                                            "Bitte komme so schnell wie möglich zu meinem Königlichen Schloss und hole dir die Karte zum" +
                                            "\r\n\r\nEuer demütiger König, im Angesicht der Dunkelheit und des Glanzes der Weihnachtszeit," +
                                            "\r\nKönig Purzel", 2000);
                            break;
                        }

                    case ConsoleKey.N:
                        {
                            GameManager.item1 = false;
                            TextAnimateTime("Du öffnest also nicht den Brief des Königs und machst stattdessen mit den Briefen der Kinder weiter",500);
                            TextAnimateTime("Abends kommst du in deiner kleinen Waldhütte an und verbringst den Abend damit " +
                                "dich zu fragen was der Brief wohl für geheime informationen enthielt", 1000);
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            TextAnimateTime("Bitte entscheide dich ob du den Brief öffnen willst oder nicht!\n", 1000);
                            FrAnt = false;
                        }
                        break;
                }
            }
            if(GameManager.item1 == true)
            {
                TextAnimate("Du schaust erschrocken nach oben, stehst sofort auf und machst dich auf den Weg, der Einladung des Königs nachzukommen");
            }
        }
        public override IStates CheckState()
        {
            return null;
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
                    Thread.Sleep(1);
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
