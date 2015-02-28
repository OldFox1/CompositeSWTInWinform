using System;
using System.Diagnostics;
using System.IO;

namespace Controls
{
    public class ProcessStdCommunicator : ICommunicator
    {
        private readonly Process _process;

        private readonly TextWriter _writer;
        public ProcessStdCommunicator(Process process)
        {
            _writer = process.StandardInput;
            _process = process;

            _process.BeginOutputReadLine();
            _process.EnableRaisingEvents = true;
            _process.OutputDataReceived += MessageRecived;
        }


        public event Action<string> OnMessageRecived;
        private void MessageRecived(object sender, DataReceivedEventArgs e)
        {
            if ( e.Data==null)
                return;

            OnMessageRecived(e.Data);
        }

        protected virtual void OnOnMessageRecived(string obj)
        {
            Action<string> handler = OnMessageRecived;
            if (handler != null) handler(obj);
        }

        public void SendMessage(string msg)
        {
            _writer.WriteLine(msg);
        }
    }
}