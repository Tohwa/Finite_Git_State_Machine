using System.Security.Cryptography.X509Certificates;

namespace State_Machine
{

    internal class Program
    {
        public static StateMachine stateMachine = new StateMachine();

        static void Main(string[] args)
        {
            stateMachine.Start();
            while(!gameManager.letter && !gameManager.map && !gameManager.flashlight && !gameManager.winConditions)
            {
                stateMachine.Update();
            }
            
        }


    }


}
