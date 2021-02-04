using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure_Works_DI03
{
    public partial class Main_UserControl : UserControl
    {
        public Main_UserControl()
        {
            InitializeComponent();
        }

        private void largePhoto_PictureBox_Click(object sender, EventArgs e)
        {
            var ProductModel = AccesDatabase.getProductModel(AccesDatabase.getProductModel_ID());
            MemoryStream ms = new MemoryStream(ProductModel.LargePhoto);
            Image image = Image.FromStream(ms);

            largePhoto_PictureBox.Image = image;
            productModelID.Text = ProductModel.ProductModelID.ToString();
            productModel_Name.Text = ProductModel.Name;
            productModel_Price.Text = ProductModel.ListPrice.ToString();
        }

        private void largePhoto_PictureBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.largePhoto_PictureBox, "Click to the image to generate a new ProductModel");
        }
    }
}
