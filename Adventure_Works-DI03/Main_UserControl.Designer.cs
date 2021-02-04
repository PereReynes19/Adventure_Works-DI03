
namespace Adventure_Works_DI03
{
    partial class Main_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productModelID = new System.Windows.Forms.TextBox();
            this.largePhoto_PictureBox = new System.Windows.Forms.PictureBox();
            this.productModel_Name = new System.Windows.Forms.TextBox();
            this.productModel_Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.largePhoto_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // productModelID
            // 
            this.productModelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productModelID.Location = new System.Drawing.Point(15, 344);
            this.productModelID.Name = "productModelID";
            this.productModelID.Size = new System.Drawing.Size(96, 21);
            this.productModelID.TabIndex = 0;
            // 
            // largePhoto_PictureBox
            // 
            this.largePhoto_PictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.largePhoto_PictureBox.Location = new System.Drawing.Point(15, 17);
            this.largePhoto_PictureBox.Name = "largePhoto_PictureBox";
            this.largePhoto_PictureBox.Size = new System.Drawing.Size(406, 281);
            this.largePhoto_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.largePhoto_PictureBox.TabIndex = 1;
            this.largePhoto_PictureBox.TabStop = false;
            this.largePhoto_PictureBox.Click += new System.EventHandler(this.largePhoto_PictureBox_Click);
            this.largePhoto_PictureBox.MouseHover += new System.EventHandler(this.largePhoto_PictureBox_MouseHover);
            // 
            // productModel_Name
            // 
            this.productModel_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productModel_Name.Location = new System.Drawing.Point(15, 408);
            this.productModel_Name.Name = "productModel_Name";
            this.productModel_Name.Size = new System.Drawing.Size(208, 21);
            this.productModel_Name.TabIndex = 2;
            // 
            // productModel_Price
            // 
            this.productModel_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productModel_Price.Location = new System.Drawing.Point(325, 344);
            this.productModel_Price.Name = "productModel_Price";
            this.productModel_Price.Size = new System.Drawing.Size(96, 21);
            this.productModel_Price.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GrayText;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(11, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Identificator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(321, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GrayText;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(13, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Product Model";
            // 
            // Main_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productModel_Price);
            this.Controls.Add(this.productModel_Name);
            this.Controls.Add(this.largePhoto_PictureBox);
            this.Controls.Add(this.productModelID);
            this.Name = "Main_UserControl";
            this.Size = new System.Drawing.Size(435, 542);
            ((System.ComponentModel.ISupportInitialize)(this.largePhoto_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productModelID;
        private System.Windows.Forms.PictureBox largePhoto_PictureBox;
        private System.Windows.Forms.TextBox productModel_Name;
        private System.Windows.Forms.TextBox productModel_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
