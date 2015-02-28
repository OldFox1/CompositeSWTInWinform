namespace ChildWindow
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
            this.communicationControl1 = new Controls.CommunicationControl();
            this.SuspendLayout();
            // 
            // communicationControl1
            // 
            this.communicationControl1.Communicator = null;
            this.communicationControl1.Location = new System.Drawing.Point(13, 13);
            this.communicationControl1.Name = "communicationControl1";
            this.communicationControl1.Size = new System.Drawing.Size(673, 535);
            this.communicationControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 564);
            this.Controls.Add(this.communicationControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CommunicationControl communicationControl1;
    }
}

