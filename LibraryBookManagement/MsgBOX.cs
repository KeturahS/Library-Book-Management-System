using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBookManagement
{


    public partial class MsgBOX : Form
    {
        private Label labelMessage;
        private Button buttonOK;
        
        public MsgBOX()
        {
            InitializeComponent();
            this.labelMessage = new Label();
            this.buttonOK = new Button();
          

            // 
            // CustomMessageBox
            // 
            this.BackColor = Color.LightYellow;
            this.Font = new Font("Aharoni", 12);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ClientSize = new Size(400, 150);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonOK);
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

        private void MsgBOX_Load(object sender, EventArgs e)
        {

        }
    }
}