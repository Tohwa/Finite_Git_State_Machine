using System.Security.Cryptography.X509Certificates;

namespace State_Machine
{

    internal class Program
    {
        public static StateMachine stateMachine = new StateMachine();

        static void Main(string[] args)
        {
            stateMachine.Init();

            while(!GameManager.letter && !GameManager.map && !GameManager.flashlight && !GameManager.winConditions || !GameManager.item1 && !GameManager.item2 && !GameManager.item3)
            {
                stateMachine.Update();
            }
            
        }


    }


}
