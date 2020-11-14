using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebModels
{
    public class Bill
    {
        public int bil_ID { get; set; }
        public int cus_ID { get; set; }
        public int hou_ID { get; set; }
        public int money { get; set; }
        public string status { get; set; }
        public string level { get; set; }
        public int changed_date { get; set; }
    }
}
