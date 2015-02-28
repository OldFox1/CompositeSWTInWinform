using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using PerentWindow;

namespace Controls
{


    public class CompositeApplicationControl : Panel
    {

        private IntPtr _applicationWindowHandle;
        //private bool _created;
        private Process _childProcess;

        [Category("Data")]
        [Description("Relative path to the executiable co load")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ExecutiablePath { get; set; }

        public Process ChildProcess
        {
            set
            {
                CloseChild();
                _childProcess = value;

                _childProcess.WaitForInputIdle();

                // Get the main handle
                _applicationWindowHandle = _childProcess.MainWindowHandle;

                Win32Api.SetParent(_applicationWindowHandle, this.Handle);

                Win32Api.SetWindowLong(_applicationWindowHandle, Win32Api.Messages.GWL_STYLE, Win32Api.Messages.WS_VISIBLE);

                Win32Api.MoveWindow(_applicationWindowHandle, 0, 0, this.Width, this.Height, true);
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            this.Invalidate();
            base.OnSizeChanged(e);
        }


        protected override void OnHandleDestroyed(EventArgs e)
        {
            CloseChild();

            base.OnHandleDestroyed(e);
        }

        private void CloseChild()
        {
            if (_applicationWindowHandle != IntPtr.Zero)
            {
                Win32Api.PostMessage(_applicationWindowHandle, Win32Api.Messages.WM_CLOSE, 0, 0);

                System.Threading.Thread.Sleep(1000);

                _applicationWindowHandle = IntPtr.Zero;

                _childProcess.Kill();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            if (_applicationWindowHandle != IntPtr.Zero)
            {
                Win32Api.MoveWindow(_applicationWindowHandle, 0, 0, this.Width, this.Height, true);

            }
            base.OnResize(e);
        }

    }
}
