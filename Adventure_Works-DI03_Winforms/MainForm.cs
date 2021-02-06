
using Adventure_Works_DI03;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure_Works_DI03_Winforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            main_UserControl1.ButtonSizeClicky += getDataFromUserControl;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void getDataFromUserControl(object sender, CustomSizeEventArgs e)
        {
            productID_TextBox.Text = e.ID;
        }
    }
}
