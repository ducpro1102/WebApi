using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;
using WebModels;
using WebServices;

namespace WebAPI.Controllers
{
    public class AddressController : ApiController
    {
        [HttpGet]
        public IHttpActionResult ViewProvince()
        {
            var claimsIdentity = (ClaimsIdentity)RequestContext.Principal.Identity;
            //string strUserName = claimsIdentity.Claims.FirstOrDefault(c => c.Type == "UserName").Value;
            //string strFullName = claimsIdentity.Claims.FirstOrDefault(c => c.Type == "FullName").Value;

            GenericService<Province> generic = new GenericService<Province>();
            var proList = generic.ExcuteMany("pro_view_all_province", null);
            return Ok(proList);
        }

        [HttpGet]
        public IHttpActionResult ViewDistrict(int province_id)
        {
            GenericService<District> generic = new GenericService<District>();
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@province_id", province_id);
            var proList = generic.ExcuteMany("pro_view_all_district", parameter);
            return Ok(proList);
        }
        [HttpGet]
        public IHttpActionResult ViewWard(int province_id,int district_id)
        {
            GenericService<Ward> generic = new GenericService<Ward>();
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@province_id", province_id);
            parameter.Add("@district_id", district_id);
            var warList = generic.ExcuteMany("pro_view_all_ward", parameter);
            return Ok(warList);
        }

        [HttpGet]
        public IHttpActionResult ViewStreet(int province_id, int district_id)
        {
            GenericService<Street> generic = new GenericService<Street>();
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@province_id", province_id);
            parameter.Add("@district_id", district_id);
            var strList = generic.ExcuteMany("pro_view_all_street", parameter);
            return Ok(strList);
        }

        [HttpGet]
        public IHttpActionResult ViewArea(int province_id, int district_id)
        {
            GenericService<Area> generic = new GenericService<Area>();
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@province_id", province_id);
            parameter.Add("@district_id", district_id);
            var areList = generic.ExcuteMany("pro_view_all_area", parameter);
            return Ok(areList);
        }
    }
}
