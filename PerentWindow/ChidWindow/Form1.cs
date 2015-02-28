using System.Windows.Forms;
using Controls;

namespace ChildWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            communicationControl1.Communicator=new ConsoleCommunicator();
        }
    }
}
