using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSPOS.BLL
{
    public class OrderRecord
    {

        public string TableName { get; set; }
        public string WaiterName { get; set; }
        public int ProductCode { get; set; }
        public int Quantity { get; set; }
        public string Section { get; set; }
        public string TablePosition { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal TotalPrice => Quantity * ProductPrice;

    }
}
