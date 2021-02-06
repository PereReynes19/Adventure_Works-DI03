
namespace Adventure_Works_DI03_Winforms
{
    partial class MainForm
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
            this.productID_TextBox = new System.Windows.Forms.TextBox();
            this.main_UserControl1 = new Adventure_Works_DI03.Main_UserControl();
            this.SuspendLayout();
            // 
            // productID_TextBox
            // 
            this.productID_TextBox.Location = new System.Drawing.Point(506, 238);
            this.productID_TextBox.Name = "productID_TextBox";
            this.productID_TextBox.Size = new System.Drawing.Size(120, 20);
            this.productID_TextBox.TabIndex = 1;
            // 
            // main_UserControl1
            // 
            this.main_UserControl1.BackColor = System.Drawing.SystemColors.GrayText;
            this.main_UserControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.main_UserControl1.Location = new System.Drawing.Point(12, 6);
            this.main_UserControl1.Name = "main_UserControl1";
            this.main_UserControl1.Size = new System.Drawing.Size(439, 546);
            this.main_UserControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(653, 551);
            this.Controls.Add(this.productID_TextBox);
            this.Controls.Add(this.main_UserControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Adventure_Works_DI03.Main_UserControl main_UserControl1;
        private System.Windows.Forms.TextBox productID_TextBox;
    }
}

