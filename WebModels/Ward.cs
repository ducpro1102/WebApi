using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebModels
{
    public class Ward
    {
        public int id { get; set; }
        public string _name { get; set; }
        public string _prefix { get; set; }
        public int _province_id { get; set; }
        public int _district_id { get; set; }
    }
}
