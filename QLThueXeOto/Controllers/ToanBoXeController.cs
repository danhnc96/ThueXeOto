using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLThueXeOto.Models;

namespace QLThueXeOto.Controllers
{
    public class ToanBoXeController : Controller
    {
        //
        // GET: /ToanBoXe/
        QuanLyThueXeOtoEntities db = new QuanLyThueXeOtoEntities();
        public ActionResult ToanBoXe()
        {
            return View(db.Xes.ToList());
        }
	}
}