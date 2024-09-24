namespace LibraryBookManagement
{
    partial class FormBookReport
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
            this.textBoxReport = new System.Windows.Forms.TextBox();
            this.textBoxReportTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxReport
            // 
            this.textBoxReport.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxReport.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxReport.Location = new System.Drawing.Point(0, 175);
            this.textBoxReport.Multiline = true;
            this.textBoxReport.Name = "textBoxReport";
            this.textBoxReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReport.Size = new System.Drawing.Size(1109, 408);
            this.textBoxReport.TabIndex = 0;
            this.textBoxReport.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxReportTitle
            // 
            this.textBoxReportTitle.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxReportTitle.Font = new System.Drawing.Font("Aharoni", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReportTitle.Location = new System.Drawing.Point(0, 2);
            this.textBoxReportTitle.Multiline = true;
            this.textBoxReportTitle.Name = "textBoxReportTitle";
            this.textBoxReportTitle.Size = new System.Drawing.Size(1086, 174);
            this.textBoxReportTitle.TabIndex = 1;
            this.textBoxReportTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // FormBookReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1110, 589);
            this.Controls.Add(this.textBoxReportTitle);
            this.Controls.Add(this.textBoxReport);
            this.Name = "FormBookReport";
            this.Text = "FormBookReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxReport;
        private System.Windows.Forms.TextBox textBoxReportTitle;
    }
}