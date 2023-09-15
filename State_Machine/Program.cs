using System.Security.Cryptography.X509Certificates;

namespace State_Machine
{

    internal class Program
    {
        public static StateMachine stateMachine = new StateMachine();

        static void Main(string[] args)
        {
            stateMachine.Init();

            while(true)
            {
                stateMachine.Update();
            }
            
        }


    }


}
