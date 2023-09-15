using System.Security.Cryptography.X509Certificates;

namespace State_Machine
{

    internal class Program
    {
        public static GameManager gameManager = new GameManager();
        public static StateMachine stateMachine = new StateMachine();

        static void Main(string[] args)
        {
            stateMachine.Start();
            while(!gameManager.letter && !gameManager.map && !gameManager.flashlight)
            {
                stateMachine.Update();
            }

            Console.WriteLine("You win?");
        }


    }


}
