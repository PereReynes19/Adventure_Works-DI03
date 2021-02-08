using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        Product product = new Product();
        public event EventHandler<CustomSizeEventArgs> ButtonSizeClicky; //Creacion del evento

        public virtual void OnButtonSizeClicky(CustomSizeEventArgs e)
        {
            ButtonSizeClicky?.Invoke(this, e); //Invocar el evento
        }
        public Main_UserControl()
        {
            InitializeComponent();
        }

        private void largePhoto_PictureBox_Click(object sender, EventArgs e)
        {
            int productID = AccesDatabase.getProductModel_ID();
            var ProductModel = AccesDatabase.getProductModel(productID);
            MemoryStream ms = new MemoryStream(ProductModel.LargePhoto);
            Image image = Image.FromStream(ms);

            largePhoto_PictureBox.Image = image;
            productModelID.Text = ProductModel.ProductModelID.ToString();
            productModel_Name.Text = ProductModel.Name;
            productModel_Price.Text = ProductModel.ListPrice.ToString();

            productModelID.Enabled = false;
            productModel_Name.Enabled = false;
            productModel_Price.Enabled = false;
            showButtonsSize(productID);
        }

        private void largePhoto_PictureBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.largePhoto_PictureBox, "Click to display a new product");
        }

        private void showButtonsSize(int id)
        {
            List<Product> sizesPro = AccesDatabase.getProductModel_Sizes(id);
            button_FlowLayout.Controls.Clear();
            foreach (var size in sizesPro)
            {
                if (size.Size != null)
                {
                    Button b = new Button();
                    b.Text = size.Size;
                    b.Name = size.ProductID.ToString();
                    button_FlowLayout.Controls.Add(b);

                    b.Click += buttonOnClicky;
                }
            }       
        }
        
        public void buttonOnClicky(object sender, EventArgs e)
        {
            product.ProductID = Int32.Parse(((Button)sender).Name); //Conseguir id
            CustomSizeEventArgs args = new CustomSizeEventArgs(product); //se le pasa los argumentos al evento
            OnButtonSizeClicky(args);
        }
    }
}
