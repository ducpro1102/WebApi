using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebModels;
using WebServices;

namespace WebAPI.Areas.Customer.Controllers
{
    public class HouseController : Controller
    {
        // GET: Customer/House

        // GET: House
        public ActionResult CreateHouse(int cus_ID, int street_ID, int district_ID,
                                        int province_ID, int area_ID, int ward_ID, string address_detail,
                                        int floor_area, int u_floor_area, int horizontal, int vertical,
                                        string house_category, int nobedroom, int notoilet, string direction)
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

            var stdList = generic.ExcuteNoneQuery("pro_add_house", parameter);
            return Json("OK");
        }
        public ActionResult EditHouse(int hou_ID, int cus_ID, int street_ID, int district_ID,
            int province_ID, int area_ID, int ward_ID, string address_detail,
                                        int floor_area, int u_floor_area, int horizontal, int vertical,
                                        string house_category, int nobedroom, int notoilet, string direction)
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
            var stdList = generic.ExcuteNoneQuery("pro_edit_all_house", parameter);
            return Json("OK");
        }
        public ActionResult ViewAllHouse(int cus_ID, int street_ID, int district_ID,
            int province_ID, int area_ID, int ward_ID, string address_detail,
            int floor_area, int u_floor_area, int horizontal, int vertical,
            string house_category, int nobedroom, int notoilet, string direction)
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
            var stdList = generic.ExcuteNoneQuery("pro_edit_all_house", parameter);
            return Json(stdList);
        }
        public ActionResult DeleteHouse(int hou_ID)
        {
            GenericService<House> generic = new GenericService<House>();
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@hou_ID", hou_ID);
            var stdList = generic.ExcuteMany("pro_delete_all_house", parameter);
            return Json("OK");
        }
    }
}