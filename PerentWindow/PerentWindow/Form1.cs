using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controls;

namespace PerentWindow
{
    public partial class Form1 : Form
    {
        public Form1(Process child)
        {
            InitializeComponent();

            compositeApplicationControl1.ChildProcess = child;

            communicationControl1.Communicator = new ProcessStdCommunicator(child);

        }

    }
}
