using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using WebModels;
//using System.Web.Mvc;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/home")]
    public class HomeController : ApiController
    {
        List<House> list = new List<House>();
        public HomeController()
        {
            House objHouse1 = new House();
            objHouse1.hou_ID = 10;
            objHouse1.h_description = "Chung cư mini";
            objHouse1.url_image1 = "http://192.168.1.20:8066/api/home/GenerateFile?fileName=house.png";
            objHouse1.house_category = "Rộng: 35 m2, Mặt tiền: 4.5m";
            objHouse1.address_detail = "Ngõ: rộng 3m";
            list.Add(objHouse1);

            House objHouse2 = new House();
            objHouse2.hou_ID = 11;
            objHouse2.h_description = "Chung cư mini";
            objHouse2.url_image1 = "http://192.168.1.20:8066/api/home/GenerateFile?fileName=bank.png";
            objHouse2.house_category = "Rộng: 35 m2, Mặt tiền: 4.5m";
            objHouse2.address_detail = "Ngõ: rộng 3m";
            list.Add(objHouse2);

            House objHouse3 = new House();
            objHouse3.hou_ID = 12;
            objHouse3.h_description = "Chung cư mini";
            objHouse3.url_image1 = "http://192.168.1.20:8066/api/home/GenerateFile?fileName=house.png";
            objHouse3.house_category = "Rộng: 35 m2, Mặt tiền: 4.5m";
            objHouse3.address_detail = "Ngõ: rộng 3m";
            list.Add(objHouse3);

            //list.Add(new House(11, "Nhà ngõ đường rộng 3m", "http://192.168.1.20:8066/api/home/GenerateFile?fileName=bank.png", "Rộng: 55 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            //list.Add(new House(12, "Chung cư 3 phòng ngủ", "http://192.168.1.20:8066/api/home/GenerateFile?fileName=house.png", "Rộng: 60 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            //list.Add(new House(13, "Nhà mặt phố, ô tô vào", "http://192.168.1.20:8066/api/home/GenerateFile?fileName=house.png", "Rộng: 35 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            //list.Add(new House(14, "Nhà ngõ đường rộng 3m", "http://192.168.1.20:8066/api/home/GenerateFile?fileName=bank.png", "Rộng: 55 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            //list.Add(new House(15, "Chung cư 3 phòng ngủ", "http://192.168.1.20:8066/api/home/GenerateFile?fileName=house.png", "Rộng: 60 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            //list.Add(new House(16, "Nhà mặt phố, ô tô vào", "http://192.168.1.20:8066/api/home/GenerateFile?fileName=house.png", "Rộng: 35 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            //list.Add(new House(17, "Nhà ngõ đường rộng 3m", "http://192.168.1.20:8066/api/home/GenerateFile?fileName=bank.png", "Rộng: 55 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            //list.Add(new House(18, "Chung cư 3 phòng ngủ", "http://192.168.1.20:8066/api/home/GenerateFile?fileName=house.png", "Rộng: 60 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            //list.Add(new House(19, "Nhà mặt phố, ô tô vào", "http://192.168.1.20:8066/api/home/GenerateFile?fileName=house.png", "Rộng: 35 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            //list.Add(new House(20, "Nhà ngõ đường rộng 3m", "http://192.168.1.20:8066/api/home/GenerateFile?fileName=bank.png", "Rộng: 55 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            //list.Add(new House(21, "Chung cư 3 phòng ngủ", "http://192.168.1.20:8066/api/home/GenerateFile?fileName=house.png", "Rộng: 60 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            //list.Add(new House(22, "Nhà mặt phố, ô tô vào", "http://192.168.1.20:8066/api/home/GenerateFile?fileName=house.png", "Rộng: 35 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            //list.Add(new House(23, "Nhà ngõ đường rộng 3m", "http://192.168.1.20:8066/api/home/GenerateFile?fileName=bank.png", "Rộng: 55 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            //list.Add(new House(24, "Chung cư 3 phòng ngủ", "http://192.168.1.20:8066/api/home/GenerateFile?fileName=house.png", "Rộng: 60 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            //list.Add(new House(25, "Nhà mặt phố, ô tô vào", "http://192.168.1.20:8066/api/home/GenerateFile?fileName=house.png", "Rộng: 35 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            //list.Add(new House(26, "Nhà ngõ đường rộng 3m", "http://192.168.1.20:8066/api/home/GenerateFile?fileName=bank.png", "Rộng: 55 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            //list.Add(new House(27, "Chung cư 3 phòng ngủ", "http://192.168.1.20:8066/api/home/GenerateFile?fileName=house.png", "Rộng: 60 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            //list.Add(new House(28, "Chung cư 3 phòng ngủ", "http://192.168.1.20:8066/api/home/GenerateFile?fileName=house.png", "Rộng: 60 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            //list.Add(new House(29, "Nhà mặt phố, ô tô vào", "http://192.168.1.20:8066/api/home/GenerateFile?fileName=house.png", "Rộng: 35 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
        }
        [Route("GetHomePage")]
        [HttpPost]
        public IHttpActionResult GetHomePage([FromBody] House house)
        {
            return Json(list);
        }
        [HttpGet]
        public HttpResponseMessage GenerateFile(string fileName)
        {
            FileStream fs = new FileStream(@"D:\DoAn\Image\" + fileName, FileMode.Open,FileAccess.Read);
            MemoryStream stream = new MemoryStream();
            fs.CopyTo(stream);
            // processing the stream.

            var result = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent(stream.ToArray())
            };
            result.Content.Headers.ContentDisposition =
                new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment")
                {
                    FileName = fileName
                };
            result.Content.Headers.ContentType = new MediaTypeHeaderValue("image/png");

            return result;
        }
        [Route("ViewDetails")]
        [HttpGet]
        public IHttpActionResult ViewDetails([FromUri] House house)
        {
            House obj = list.Find(x => x.hou_ID == house.hou_ID);
            return Json(obj);
        }
    }
}