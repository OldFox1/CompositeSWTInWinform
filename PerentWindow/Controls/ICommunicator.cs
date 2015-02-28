using System;
using System.IO;

namespace Controls
{
    public interface ICommunicator
    {
        event Action<string> OnMessageRecived;

        void SendMessage(string msg);
    }

}