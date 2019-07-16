using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLThueXeOto.Models;

namespace QLThueXeOto.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        QuanLyThueXeOtoEntities db = new QuanLyThueXeOtoEntities();
        public ActionResult Index()
        {
            return View(db.Xes.Take(8).ToList());
        }
        public ActionResult HuongDanChiTiet()
        {
            return View();
        }
    }
}