using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebModels;
using WebServices;

namespace WebAPI.Controllers
{
    public class BillController : ApiController
    {

        [HttpPost]
        public IHttpActionResult CreateBill(int cus_ID, int hou_ID, int money, string status, string level, string changed_date, string category,string bil_description)
        {
            GenericService<Bill> generic = new GenericService<Bill>();
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@hou_ID", hou_ID);
            parameter.Add("@cus_ID", cus_ID);
            parameter.Add("@money", money);
            parameter.Add("@status", status);
            parameter.Add("@level", level);
            parameter.Add("@changed_date", changed_date);
            parameter.Add("@category", category);
            parameter.Add("@bil_description", bil_description);

            var stdList = generic.ExcuteNoneQuery("pro_add_bill", parameter);
            return Ok();
        }
    }
}
