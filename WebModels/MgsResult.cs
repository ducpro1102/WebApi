using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebModels
{

    //[DataContract]
    public class MgsResult
    {
        public MgsResult()
        { }
        public int state { get; set; }
        public string message { get; set; }
    }
}
