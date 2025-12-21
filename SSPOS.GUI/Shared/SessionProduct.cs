using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSPOS.GUI.Shared
{
    public partial class SessionProduct
    {
        private static int  _productId;
        private static string _productName;
        private static string _productCode;

        public static int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        public static string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        public static string ProductCode
        {
            get { return _productCode; }
            set { _productCode = value; }
        }
    }
}
