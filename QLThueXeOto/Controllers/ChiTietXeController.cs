using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLThueXeOto.Models;

namespace QLThueXeOto.Controllers
{
    public class ChiTietXeController : Controller
    {
        //
        // GET: /ChiTietXe/
        QuanLyThueXeOtoEntities db = new QuanLyThueXeOtoEntities();
        public ViewResult ChiTietXe(string MaXe)
        {
            Xe xe = db.Xes.SingleOrDefault(n=>n.MaXe==MaXe);
            if (xe == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(xe);
        }
	}
}