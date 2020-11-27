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
        public IHttpActionResult CreateHouse([FromBody] House house)
        {
            GenericService<House> generic = new GenericService<House>();
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@cus_ID", house.cus_ID);
            parameter.Add("@street_ID", house.street_ID);
            parameter.Add("@district_ID", house.district_ID);
            parameter.Add("@province_ID", house.province_ID);
            parameter.Add("@area_ID", house.area_ID);
            parameter.Add("@ward_ID", house.ward_ID);
            parameter.Add("@address_detail", house.address_detail);
            parameter.Add("@floor_area", house.floor_area);
            parameter.Add("@u_floor_area", house.u_floor_area);
            parameter.Add("@horizontal", house.horizontal);
            parameter.Add("@vertical", house.vertical);
            parameter.Add("@house_category", house.house_category);
            parameter.Add("@nobedroom", house.nobedroom);
            parameter.Add("@notoilet", house.notoilet);
            parameter.Add("@direction", house.direction);
            parameter.Add("@h_description", house.h_description);
            var claimsIdentity = (ClaimsIdentity)RequestContext.Principal.Identity;
            string strUserName = claimsIdentity.Claims.FirstOrDefault(c => c.Type == "UserName").Value;
            parameter.Add("@user_name", strUserName);
            var stdList = generic.ExcuteNoneQuery("pro_add_house", parameter);
            return Ok();
        }
        [HttpPost]
        public IHttpActionResult EditHouse([FromBody] House house)
        {
            GenericService<House> generic = new GenericService<House>();
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@hou_ID", house.hou_ID);
            parameter.Add("@cus_ID", house.cus_ID);
            parameter.Add("@street_ID", house.street_ID);
            parameter.Add("@district_ID", house.district_ID);
            parameter.Add("@province_ID", house.province_ID);
            parameter.Add("@area_ID", house.area_ID);
            parameter.Add("@ward_ID", house.ward_ID);
            parameter.Add("@address_detail", house.address_detail);
            parameter.Add("@floor_area", house.floor_area);
            parameter.Add("@u_floor_area", house.u_floor_area);
            parameter.Add("@horizontal", house.horizontal);
            parameter.Add("@vertical", house.vertical);
            parameter.Add("@house_category", house.house_category);
            parameter.Add("@nobedroom", house.nobedroom);
            parameter.Add("@notoilet", house.notoilet);
            parameter.Add("@direction", house.direction);
            parameter.Add("@h_description", house.h_description);
            var stdList = generic.ExcuteNoneQuery("pro_edit_all_house", parameter);
            return Ok();
        }
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult ViewAllHouse([FromBody] House house)
        {
            GenericService<House> generic = new GenericService<House>();
            DynamicParameters parameter = new DynamicParameters();
           
            parameter.Add("@province_ID", house.province_ID);
            parameter.Add("@floor_area", house.floor_area);
            parameter.Add("@house_category", house.house_category);
            parameter.Add("@price", house.price);

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
            //var claimsIdentity = (ClaimsIdentity)RequestCont0ext.Principal.Identity;
            //string strUserName = claimsIdentity.Claims.FirstOrDefault(c => c.Type == "UserName").Value;
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
