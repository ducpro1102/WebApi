using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebModels
{
    public class House
    {
<<<<<<< HEAD
        public long hou_ID { get; set; }
        public long cus_ID { get; set; }
        public long street_ID { get; set; }
        public long district_ID { get; set; }
        public long province_ID { get; set; }
        public long area_ID { get; set; }
        public long ward_ID { get; set; }
=======
        public decimal? hou_ID { get; set; }
        public decimal cus_ID { get; set; }
        public decimal street_ID { get; set; }
        public decimal district_ID { get; set; }
        public decimal province_ID { get; set; }
        public decimal area_ID { get; set; }  
        public decimal ward_ID { get; set; }
>>>>>>> c2759bf166e9a35cd0ec1b7eb3b4e65362d9abb8
        public string address_detail { get; set; }
        public long floor_area { get; set; }
        public long u_floor_area { get; set; }
        public long horizontal { get; set; }
        public long vertical { get; set; }
        public string house_category { get; set; }
        public long nobedroom { get; set; }
        public long notoilet { get; set; }
        public string direction { get; set; }
        public string h_description { get; set; }
<<<<<<< HEAD
        public string url_image1 { get; set; }
        public string url_image2 { get; set; }
        public string url_image3 { get; set; }
=======
        public string url_Img { get; set; }
        public string b_description { get; set; }
        public decimal price { get; set; }
>>>>>>> c2759bf166e9a35cd0ec1b7eb3b4e65362d9abb8
    }
}
