using Microsoft.AspNetCore.Mvc;

namespace TinhLai.Controllers
{
    public class LaiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(string sotien, double laisuat, uint kyhan)
        {
            string sotien_string = sotien.Replace(",", ""); // loại bỏ ký tự phân cách
            int sotien_number = int.Parse(sotien_string);
            ViewData["sotien"] = sotien;
            ViewData["laisuat"] = laisuat;
            ViewData["kyhan"] = kyhan;
            double tienlai = sotien_number * kyhan * laisuat/1200;
            double tongtien = sotien_number + tienlai;
            ViewData["tienLai"] = tienlai.ToString(tienlai % 1 == 0 ? "N0" : "N2");
            ViewData["tongTien"] = tongtien.ToString(tongtien % 1 == 0 ? "N0" : "N2");
            return View();
        }
    }
}
