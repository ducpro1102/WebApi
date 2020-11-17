﻿using Dapper;
using System.Web.Http;
using WebModels;
using WebServices;

namespace WebAPI.Controllers
{
    public class HouseController : ApiController
    {
        [HttpPost]
        public IHttpActionResult CreateHouse(int cus_ID, int street_ID, int district_ID,
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
            return Ok();
        }
        [HttpPost]
        public IHttpActionResult EditHouse(int hou_ID, int cus_ID, int street_ID, int district_ID,
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
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult ViewAllHouse(int cus_ID, int street_ID, int district_ID,
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
            var stdList = generic.ExcuteMany("pro_edit_all_house", parameter);
            return Ok(stdList);
        }
        [HttpPost]
        public IHttpActionResult DeleteHouse(int hou_ID)
        {
            GenericService<House> generic = new GenericService<House>();
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@hou_ID", hou_ID);
            var stdList = generic.ExcuteMany("pro_delete_all_house", parameter);
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult ViewHouse()
        {
            GenericService<House> generic = new GenericService<House>();
            var stdList = generic.ExcuteMany("view_all_house", null);
            return Ok(stdList);
        }
    }
}