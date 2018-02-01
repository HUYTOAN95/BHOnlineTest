using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using BHOnlineTest.Models;

namespace BHOnlineTest.Controllers
{
    public class HomeController : Controller
    {
        BHOnlineContext db = new BHOnlineContext();
        // GET: /Home/
        public ActionResult Index(int ? page )
        {   int pageSize = 9;
            //Tạo biến số trang
            int pageNumber = (page ?? 1);
            return View(db.bh_sanpham.Where(n=>n.Ma!="").OrderBy(n=>n.Ma).ToPagedList(pageNumber,pageSize));
           
        }
	}
}