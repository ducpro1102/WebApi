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
        List<HouseTest> list = new List<HouseTest>();
        public HomeController()
        {
            list.Add(new HouseTest(10, "Chung cư mini", "http://192.168.1.20:8085/api/home/GenerateFile?fileName=house.png", "Rộng: 35 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            list.Add(new HouseTest(11, "Nhà ngõ đường rộng 3m", "http://192.168.1.20:8085/api/home/GenerateFile?fileName=bank.png", "Rộng: 55 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            list.Add(new HouseTest(12, "Chung cư 3 phòng ngủ", "http://192.168.1.20:8085/api/home/GenerateFile?fileName=house.png", "Rộng: 60 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            list.Add(new HouseTest(13, "Nhà mặt phố, ô tô vào", "http://192.168.1.20:8085/api/home/GenerateFile?fileName=house.png", "Rộng: 35 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            list.Add(new HouseTest(14, "Nhà ngõ đường rộng 3m", "http://192.168.1.20:8085/api/home/GenerateFile?fileName=bank.png", "Rộng: 55 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            list.Add(new HouseTest(15, "Chung cư 3 phòng ngủ", "http://192.168.1.20:8085/api/home/GenerateFile?fileName=house.png", "Rộng: 60 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            list.Add(new HouseTest(16, "Nhà mặt phố, ô tô vào", "http://192.168.1.20:8085/api/home/GenerateFile?fileName=house.png", "Rộng: 35 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            list.Add(new HouseTest(17, "Nhà ngõ đường rộng 3m", "http://192.168.1.20:8085/api/home/GenerateFile?fileName=bank.png", "Rộng: 55 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            list.Add(new HouseTest(18, "Chung cư 3 phòng ngủ", "http://192.168.1.20:8085/api/home/GenerateFile?fileName=house.png", "Rộng: 60 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            list.Add(new HouseTest(19, "Nhà mặt phố, ô tô vào", "http://192.168.1.20:8085/api/home/GenerateFile?fileName=house.png", "Rộng: 35 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            list.Add(new HouseTest(20, "Nhà ngõ đường rộng 3m", "http://192.168.1.20:8085/api/home/GenerateFile?fileName=bank.png", "Rộng: 55 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            list.Add(new HouseTest(21, "Chung cư 3 phòng ngủ", "http://192.168.1.20:8085/api/home/GenerateFile?fileName=house.png", "Rộng: 60 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            list.Add(new HouseTest(22, "Nhà mặt phố, ô tô vào", "http://192.168.1.20:8085/api/home/GenerateFile?fileName=house.png", "Rộng: 35 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            list.Add(new HouseTest(23, "Nhà ngõ đường rộng 3m", "http://192.168.1.20:8085/api/home/GenerateFile?fileName=bank.png", "Rộng: 55 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            list.Add(new HouseTest(24, "Chung cư 3 phòng ngủ", "http://192.168.1.20:8085/api/home/GenerateFile?fileName=house.png", "Rộng: 60 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            list.Add(new HouseTest(25, "Nhà mặt phố, ô tô vào", "http://192.168.1.20:8085/api/home/GenerateFile?fileName=house.png", "Rộng: 35 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            list.Add(new HouseTest(26, "Nhà ngõ đường rộng 3m", "http://192.168.1.20:8085/api/home/GenerateFile?fileName=bank.png", "Rộng: 55 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            list.Add(new HouseTest(27, "Chung cư 3 phòng ngủ", "http://192.168.1.20:8085/api/home/GenerateFile?fileName=house.png", "Rộng: 60 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            list.Add(new HouseTest(28, "Chung cư 3 phòng ngủ", "http://192.168.1.20:8085/api/home/GenerateFile?fileName=house.png", "Rộng: 60 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
            list.Add(new HouseTest(29, "Nhà mặt phố, ô tô vào", "http://192.168.1.20:8085/api/home/GenerateFile?fileName=house.png", "Rộng: 35 m2, Mặt tiền: 4.5m", "Ngõ: rộng 3m"));
        }
        [Route("GetHomePage")]
        [HttpPost]
        public IHttpActionResult GetHomePage([FromBody] HouseTest house)
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
        public IHttpActionResult ViewDetails([FromUri] HouseTest house)
        {
            HouseTest obj = list.Find(x => x.hou_id == house.hou_id);
            return Json(obj);
        }
    }
}