using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Machine
{
    internal class DasGericht : RoomBaseState
    {
        //Item 1 : Frei  0 -2 
        //Item 2 : ungenau 3 -4 
        //Item 3 : Todesstrafe 5 -6 


        public static int punkte = 0;
        public static bool validInput = false;
        public override void EnterState()
        {
            Wahrheit();
            Ansprache();
            Frage1();
            Frage2();
            Frage3();


        }
        public override IStates CheckState()
        {
            IStates tmp;

            tmp = Ergebnis();
            return tmp;
        }

        public override void UpdateState()
        {

        }

        public override void ExitState()
        {

        }



        static void Wahrheit()
        {
            Console.WriteLine("Du ( Geroge Chapman) und musst versuchen freigesprochen zu werden um weiter zu kommen.");
            Console.ReadKey(true);
            Console.WriteLine(" George Chapman hasste seinen Chef wodurch er den Mord an William H. Plante und diesen vergiften wollte.\n Als Vorwand bat George ihn sich nach Feierabend mit ihm in dem  Barbereich des Freudenhauses \"George Inn\" zu treffen, um mit ihm um sein Gehalt zu verhandeln.\n George wartete bereits auf ihn an einem Tisch, unauffällig in der Ecke.\n Er betrat im Gegensatz zu William die Bar durch eine Hintertür und war so nahezu ungesehen.\nEr füllte William ab und gab ihm eine Tablette die gegen den Kater helfen soll.\n William nahm diese und fühlte sich wenig später schlecht. Er ist auf Toilette gegangen um zu Kotzen, doch diese hatte er nie verlassen.\n George verlies die Bar wieder durch die hinter Tür und William H. wurde Tot um 03:00Uhr aufgefunden. ");
            Console.ReadKey(true);
        }

        static void Ansprache()
        {
            Console.WriteLine("*Richter Hammer wird auf den Tisch geschlagen* *BAMM* *BAMM* *BAMM* \n \n Heute ist der 05.01.1989 und wir behandeln den Mord an William Hampton, welcher am 23.12.1888 vergiftet in einer Toilette  in dem Barbereich des Freudenhauses \"George Inn\" aufgefunden wurde. \nIm Zeugenstand sitzt nun der Hauptverdächtige George Chapman. Ich würde ihnen nun ein Paar fragen stellen.   ");
            Console.ReadKey(true);
            Console.WriteLine("Stimmt es, dass sie der hier Verdächtige : George Chapman, welcher in London seit 5 Jahren Lebt und 27 Jahre alt ist, sind? ('ja' oder 'nein')");
            string antwort1 = Console.ReadLine().Trim().ToLower();


            while (true)
            {
                if (antwort1 == "ja")
                {
                    break;
                }
                if (antwort1 == "nein")
                {
                    punkte++;
                    break;
                }
            }


        }

        static void Frage1()
        {
            Console.WriteLine("Wo waren Sie zwischen 02:00 und 04:00 Uhr? ");
            Console.WriteLine("1. Im Freuden Haus \"George Inn\" \n 2. Auf dem Weg zum Zug um die Familie auf dem Land zu Besuchen \n 3. Im Badehaus \"zur erhabenen Quelle\" ");

            do
            {


                string antwort2 = Console.ReadLine();
                int aw2;

                if (int.TryParse(antwort2, out aw2))
                {


                    switch (aw2)
                    {

                        case 1:
                            {
                                punkte += 2;
                                Console.Clear();
                                Console.WriteLine("Hm....Ok");
                                Console.ReadKey(true);
                                validInput = true;
                                break;
                            }
                        case 2:
                            {
                                punkte++;
                                Console.Clear();
                                Console.WriteLine("Obwohl Sie bei Ihrer Verhaftung keinen Nachweis für eine Fahrt geben konnten?");
                                Console.ReadKey(true);
                                validInput = true;
                                break;
                            }
                        case 3:
                            {
                                Console.Clear();
                                Console.WriteLine("Ok");
                                Console.ReadKey(true);
                                validInput = true;
                                break;

                            }
                        default:
                            {
                                Console.WriteLine("*Gib bitte eine gülte Antowrt and (1 , 2 , 3)*");
                                break;
                            }

                    }



                }


            } while (!validInput);

        }


        static void Frage2()
        {
            Console.WriteLine("Wie stehen sie in Verbindung zu dem Opfer?");
            Console.WriteLine("1.Er ist mein direkter Chef in der Firma! \n2. Er ist ein entfernter Bekanter!\n3. Diese Person ist mir nicht bekannt! ");
            do
            {


                string antwort2 = Console.ReadLine();
                int aw2;
                if (int.TryParse(antwort2, out aw2))
                {


                    switch (aw2)
                    {

                        case 1:
                            {

                                Console.Clear();
                                Console.WriteLine("Stimmt mit den Beweisen überein!");
                                Console.ReadKey(true);
                                validInput = true;
                                break;
                            }
                        case 2:
                            {
                                punkte++;
                                Console.Clear();
                                Console.WriteLine("Sicher?");
                                Console.ReadKey(true);
                                validInput = true;
                                break;
                            }
                        case 3:
                            {
                                punkte += 2;
                                Console.Clear();
                                Console.WriteLine("Da bin ich anderer Meinung!");
                                Console.ReadKey(true);
                                validInput = true;
                                break;

                            }
                        default:
                            {
                                Console.WriteLine("*Gib bitte eine gülte Antowrt and (1 , 2 , 3)*");
                                break;
                            }





                    }



                }


            } while (!validInput);



        }

        static void Frage3()
        {
            Console.WriteLine("Könnten Sie das Gift wenn sie die einzelnen Komponenten wissen nachstellen?");
            Console.WriteLine("1.Nein absolut nicht !\n2.Absolut das ist kein Problem \n3.Es wäre möglich aber tendenziell nicht ");
            do
            {


                string antwort2 = Console.ReadLine();
                int aw2;
                if (int.TryParse(antwort2, out aw2))
                {


                    switch (aw2)
                    {

                        case 1:
                            {

                                Console.Clear();
                                Console.WriteLine("Naja");
                                Console.ReadKey(true);
                                validInput = true;
                                break;
                            }
                        case 2:
                            {
                                punkte += 2;
                                Console.Clear();
                                Console.WriteLine("Gelogen wie Gedruckt");
                                Console.ReadKey(true);
                                validInput = true;
                                break;
                            }
                        case 3:
                            {
                                punkte += 2;
                                Console.Clear();
                                Console.WriteLine("Einverstanden");
                                Console.ReadKey(true);
                                validInput = true;
                                break;

                            }
                        default:
                            {
                                Console.WriteLine("*Gib bitte eine gülte Antowrt and (1 , 2 , 3)*");
                                break;
                            }





                    }



                }


            } while (!validInput);







        }

        static IStates Ergebnis()
        {
            if (punkte == 5 || punkte == 6)
            {
                Console.WriteLine("Der Angeklagte wird für schuldig gesprochen!");
                GameManager.item1 = true;
                
                return new Marktplatz(); //return new Raum2();

            }

            if (punkte == 3 || punkte == 4)
            {
                Console.WriteLine("Ergebnis ist zu ungenau. Der angeklagte wird auf Bewährung freigesprochen");
                GameManager.item2 = true;
                return null;

            }

            if (punkte == 0 || punkte == 1 || punkte == 2)
            {
                Console.WriteLine("Der Angeklagte wird freigepsprochen");
                GameManager.item3 = true;
                return null;


            }

            return null;



        }
    }


}
