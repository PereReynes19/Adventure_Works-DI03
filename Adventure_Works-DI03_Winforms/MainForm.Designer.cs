
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productID_TextBox
            // 
            this.productID_TextBox.Location = new System.Drawing.Point(463, 244);
            this.productID_TextBox.Name = "productID_TextBox";
            this.productID_TextBox.Size = new System.Drawing.Size(120, 20);
            this.productID_TextBox.TabIndex = 1;
            // 
            // main_UserControl1
            // 
            this.main_UserControl1.BackColor = System.Drawing.SystemColors.GrayText;
            this.main_UserControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.main_UserControl1.Location = new System.Drawing.Point(12, 12);
            this.main_UserControl1.Name = "main_UserControl1";
            this.main_UserControl1.Size = new System.Drawing.Size(432, 524);
            this.main_UserControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product_ID";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(603, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productID_TextBox);
            this.Controls.Add(this.main_UserControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Adventure_Works_DI03.Main_UserControl main_UserControl1;
        private System.Windows.Forms.TextBox productID_TextBox;
        private System.Windows.Forms.Label label1;
    }
}

