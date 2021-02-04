
namespace Adventure_Works_DI03_Winforms
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
            this.main_UserControl1 = new Adventure_Works_DI03.Main_UserControl();
            this.SuspendLayout();
            // 
            // main_UserControl1
            // 
            this.main_UserControl1.BackColor = System.Drawing.SystemColors.GrayText;
            this.main_UserControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.main_UserControl1.Location = new System.Drawing.Point(12, 12);
            this.main_UserControl1.Name = "main_UserControl1";
            this.main_UserControl1.Size = new System.Drawing.Size(439, 546);
            this.main_UserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(653, 629);
            this.Controls.Add(this.main_UserControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Adventure_Works_DI03.Main_UserControl main_UserControl1;
    }
}

