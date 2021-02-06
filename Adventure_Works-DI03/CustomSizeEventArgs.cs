using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Works_DI03
{
    public class CustomSizeEventArgs : EventArgs
    {
        private string _ID;

        public CustomSizeEventArgs(Product product)
        {
            _ID = product.ProductID.ToString();
        }

        public string ID { get { return _ID; } }
    }
}
