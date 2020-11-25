using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web.Http;
using WebModels;
using WebServices;

namespace WebAPI.Controllers
{
    public class HouseController : ApiController
    {

        [Authorize]
        [HttpPost]
        public IHttpActionResult CreateHouse(int cus_ID, int street_ID, int district_ID,
                                       int province_ID, int area_ID, int ward_ID, string address_detail,
                                       int floor_area, int u_floor_area, int horizontal, int vertical,
                                       string house_category, int nobedroom, int notoilet, string direction ,string h_description)
        {
            GenericService<House> generic = new GenericService<House>();
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@cus_ID", cus_ID);
            parameter.Add("@street_ID", street_ID);
            parameter.Add("@district_ID", district_ID);
            parameter.Add("@province_ID", province_ID);
            parameter.Add("@area_ID", area_ID);
            parameter.Add("@ward_ID", ward_ID);
            parameter.Add("@address_detail", address_detail);
            parameter.Add("@floor_area", floor_area);
            parameter.Add("@u_floor_area", u_floor_area);
            parameter.Add("@horizontal", horizontal);
            parameter.Add("@vertical", vertical);
            parameter.Add("@house_category", house_category);
            parameter.Add("@nobedroom", nobedroom);
            parameter.Add("@notoilet", notoilet);
            parameter.Add("@direction", direction);
            parameter.Add("@h_description", h_description);

            var stdList = generic.ExcuteNoneQuery("pro_add_house", parameter);
            return Ok();
        }
        [HttpPost]
        public IHttpActionResult EditHouse(int hou_ID, int cus_ID, int street_ID, int district_ID,
            int province_ID, int area_ID, int ward_ID, string address_detail,
                                        int floor_area, int u_floor_area, int horizontal, int vertical,
                                        string house_category, int nobedroom, int notoilet, string direction,string h_description)
        {
            GenericService<House> generic = new GenericService<House>();
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@hou_ID", hou_ID);
            parameter.Add("@cus_ID", cus_ID);
            parameter.Add("@street_ID", street_ID);
            parameter.Add("@district_ID", district_ID);
            parameter.Add("@province_ID", province_ID);
            parameter.Add("@area_ID", area_ID);
            parameter.Add("@ward_ID", ward_ID);
            parameter.Add("@address_detail", address_detail);
            parameter.Add("@floor_area", floor_area);
            parameter.Add("@u_floor_area", u_floor_area);
            parameter.Add("@horizontal", horizontal);
            parameter.Add("@vertical", vertical);
            parameter.Add("@house_category", house_category);
            parameter.Add("@nobedroom", nobedroom);
            parameter.Add("@notoilet", notoilet);
            parameter.Add("@direction", direction);
            parameter.Add("@h_description", h_description);
            var stdList = generic.ExcuteNoneQuery("pro_edit_all_house", parameter);
            return Ok();
        }
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult ViewAllHouse(int province_ID,
            int floor_area, string house_category, int price)
        {
            GenericService<House> generic = new GenericService<House>();
            DynamicParameters parameter = new DynamicParameters();
           
            parameter.Add("@province_ID", province_ID);
            parameter.Add("@floor_area", floor_area);
            parameter.Add("@house_category", house_category);
            parameter.Add("@price", price);

            var stdList = generic.ExcuteMany("pro_view_all_house", parameter);
            return Ok(stdList);
        }
        [HttpPost]
        public IHttpActionResult DeleteHouse(int hou_ID)
        {
            GenericService<House> generic = new GenericService<House>();
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@hou_ID", hou_ID);
            var stdList = generic.ExcuteMany("pro_delete_all_house", parameter);
            return Ok(stdList);
        }
        [HttpGet]
        public IHttpActionResult GetHouse(int hou_ID)
        {
            GenericService<House> generic = new GenericService<House>();
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@hou_ID", hou_ID);
            var hou = generic.ExcuteSingle("pro_get_house", parameter);
            return Ok(hou);
        }


        [AllowAnonymous]
        [HttpGet]
        public IHttpActionResult ViewHouse()
        {

            ////////////////////////////
            //1.
            //var claimsIdentity = (ClaimsIdentity)RequestContext.Principal.Identity;
            //string UserName = claimsIdentity.Claims.FirstOrDefault(c => c.Type == "UserName").Value;
            ////2.
            //var userIdentity = (ClaimsIdentity)RequestContext.Principal.Identity;
            //var claims = userIdentity.Claims;
            //var roles = claims.Where(c => c.Type == ClaimTypes.Role).ToList();
            ////////////////////////////
            
            GenericService<House> generic = new GenericService<House>();
            var stdList = generic.ExcuteMany("view_all_house", null);
            return Ok(stdList);
        }
    }
}
