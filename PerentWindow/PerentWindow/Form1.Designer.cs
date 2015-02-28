using Controls;

namespace PerentWindow
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.compositeApplicationControl1 = new CompositeApplicationControl();
            this.communicationControl1 = new Controls.CommunicationControl();
            this.SuspendLayout();
            // 
            // compositeApplicationControl1
            // 
            this.compositeApplicationControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.compositeApplicationControl1.ExecutiablePath = "Child.exe";
            this.compositeApplicationControl1.Location = new System.Drawing.Point(13, 13);
            this.compositeApplicationControl1.Name = "compositeApplicationControl1";
            this.compositeApplicationControl1.Size = new System.Drawing.Size(711, 574);
            this.compositeApplicationControl1.TabIndex = 0;
            // 
            // communicationControl1
            // 
            this.communicationControl1.Communicator = null;
            this.communicationControl1.Location = new System.Drawing.Point(730, 12);
            this.communicationControl1.Name = "communicationControl1";
            this.communicationControl1.Size = new System.Drawing.Size(710, 574);
            this.communicationControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 601);
            this.Controls.Add(this.communicationControl1);
            this.Controls.Add(this.compositeApplicationControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CompositeApplicationControl compositeApplicationControl1;
        private Controls.CommunicationControl communicationControl1;
    }
}

