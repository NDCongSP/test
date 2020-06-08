using Learn.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace Learn.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Update(HomeModel model)
        {
            DBBusinessLayer updateLM = new DBBusinessLayer();
            //if (updateLM.SelectCmd(model.nhietDo, model.id) != 0)
            //{
            //    return Json(new { Status = "Ok" }, JsonRequestBehavior.AllowGet);
            //}
            return Json(new { Status = "Fail" }, JsonRequestBehavior.AllowGet);
        }

        //Locahost/Home/Get/12

        /// <summary>
        /// Đọc DB lấy các giá trị realTime lên để hiển thị.
        /// </summary>
        /// <returns></returns>
        public JsonResult GetRealTimeValues()
        {
            DBBusinessLayer dbBusinessLayer = new DBBusinessLayer();
            DataTable bangData = dbBusinessLayer.SelectCmd("trangthai", "*", "tenChuong='ChuongGa1'");
            HomeModel model = new HomeModel()
            {
                id = Convert.ToInt32(bangData.Rows[0][0].ToString()),
                tenChuong = bangData.Rows[0][1].ToString(),
                nhietDo = Convert.ToDouble(bangData.Rows[0][2].ToString()),
                doAm = Convert.ToDouble(bangData.Rows[0][3].ToString()),
                tanSo = Convert.ToDouble(bangData.Rows[0][4].ToString()),
                o2 = Convert.ToDouble(bangData.Rows[0][5].ToString()),
                co2 = Convert.ToDouble(bangData.Rows[0][6].ToString()),
                nh3 = Convert.ToDouble(bangData.Rows[0][7].ToString()),
            };
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetChartData()
        {
            DBBusinessLayer dBBusinessLayer = new DBBusinessLayer();
            DataTable bangData = dBBusinessLayer.SelectCmd("trangthai", "nhietDo,doAm", "tenChuong='ChuongGa1'");

            var chartData = new object[101];
            chartData[0] = new object[]{
                "Thời gian",
                "Nhiệt độ ",
                "Độ ẩm ",

            };
            //if (Dem < 10)
            //{
            try
            {
                for (Int16 j = 1; j <= 100; j++)
                {
                    chartData[j] = new object[] { DateTime.Now.ToString(), bangData.Rows[0][0], bangData.Rows[0][1] };
                }
            }
            catch { }

            return Json(chartData, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Test()
        {
            return View();
        }

        public ActionResult Settings()
        {
            return View();
        }

        
        public ActionResult Report()
        {
            var model = new DbReport().SelectAll();
            return View(model);
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult ChangePass()
        {
            return View();
        }

        public JsonResult UpdatePass(LoginModel model)
        {
            AccountModel updateLM = new AccountModel();
            if (model.newPassword == model.reNewPass)
            {
                if (updateLM.UpdatePassword(model.password, model.newPassword) != 0)
                {
                    return Json(new { Status = "Ok" }, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { Status = "Fail" }, JsonRequestBehavior.AllowGet);
        }
    }
}