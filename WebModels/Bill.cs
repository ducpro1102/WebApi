using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebModels
{
	public class Bill
	{
        public decimal bil_ID { get; set; }
		public decimal cus_ID { get; set; }
        public string MyProperty { get; set; }
        public decimal price { get; set; }
		public string status { get; set; }
		public string level { get; set; }
		public string changed_date { get; set; }
		public string category { get; set; }
        public string bil_description { get; set; }
    }
}
