using System;
using System.Threading.Tasks;

namespace Controls
{
    public class ConsoleCommunicator : ICommunicator
    {

        public ConsoleCommunicator()
        {
            Task.Factory.StartNew(ListenToIncomingMessages);
        }

        private void ListenToIncomingMessages()
        {
            string msg;
            while (true)
            {
                msg = Console.ReadLine();
                if (msg == null)
                    return;
                OnOnMessageRecived(msg);
            }
        }

        public event Action<string> OnMessageRecived;

        protected virtual void OnOnMessageRecived(string obj)
        {
            Action<string> handler = OnMessageRecived;
            if (handler != null) handler(obj);
        }

        public void SendMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}