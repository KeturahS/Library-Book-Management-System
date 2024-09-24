using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryBookManagement
{
    public partial class CustomMessageBox : Form
    {
        private Label labelMessage;
        private Button buttonOK;
        private Button buttonCancel;

        public CustomMessageBox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.labelMessage = new Label();
            this.buttonOK = new Button();
            this.buttonCancel = new Button();

            // 
            // CustomMessageBox
            // 
            this.BackColor = Color.LightYellow;
            this.Font = new Font("Aharoni", 14);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ClientSize = new Size(400, 150);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Text = "Custom Message Box";

            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new Point(10, 10);
            this.labelMessage.MaximumSize = new Size(380, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new Size(0, 23);

            // 
            // buttonOK
            // 
            this.buttonOK.Location = new Point(100, 80);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new Size(90, 30);
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new EventHandler(this.buttonOK_Click);

            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new Point(200, 80);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(90, 30);
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);
        }

        public void SetMessage(string message)
        {
            labelMessage.Text = message;
        }

        public static DialogResult Show(string message, string title)
        {
            using (CustomMessageBox msgBox = new CustomMessageBox())
            {
                msgBox.Text = title;
                msgBox.SetMessage(message);
                return msgBox.ShowDialog();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

