using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebModels
{

    //[DataContract]
    public class HouseTest
    {
        public HouseTest()
        { }
            public HouseTest(long loghou_id, string strHouseName, string strflagName, string strhienthi1, string strhienthi2)
        {
            hou_id = loghou_id;
            housename = strHouseName;
            flagname = strflagName;
            hienthi1 = strhienthi1;
            hienthi2 = strhienthi2;
        }
        public string housename { get; set; }
        public string flagname { get; set; }
        public string hienthi1 { get; set; }
        public string hienthi2 { get; set; }
        public long? hou_id { get; set; }
    }
}
