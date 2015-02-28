using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class CommunicationControl : UserControl
    {

        private ICommunicator _communicator;

        public ICommunicator Communicator
        {
            get
            {
                return _communicator;
            }
            set
            {
                if (_communicator != null)
                {
                    _communicator.OnMessageRecived -= RecivedMessages;
                }

                _communicator = value;
                
                if (_communicator != null)
                {
                    _communicator.OnMessageRecived += RecivedMessages;
                }
            }
        }

        public CommunicationControl()
        {
            InitializeComponent();
        }

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {
            sendButton.Enabled = !String.IsNullOrEmpty(messageTextBox.Text) && Communicator != null;
        }

        private void RecivedMessages(string msg)
        {
            WriteMessage("Recived message: " + msg);
        }


        private void WriteMessage(string msg)
        {

            if (communicationLogRichTextBox.InvokeRequired)
            {
                Invoke(new Action(() => WriteMessage(msg)));
                return;
            }
            communicationLogRichTextBox.AppendText(Environment.NewLine + msg);

        }


        private void sendButton_Click(object sender, EventArgs e)
        {
            if (Communicator == null)
                return;

            var message = messageTextBox.Text;
            messageTextBox.Clear();

            WriteMessage("Sent message: " + message);

            Communicator.SendMessage(message);

        }


    }
}
