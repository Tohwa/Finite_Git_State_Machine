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
            while(!gameManager.item1 && !gameManager.item2 && !gameManager.item3)
            {
                stateMachine.Update();
            }

            Console.WriteLine("You win?");
        }


    }


}
