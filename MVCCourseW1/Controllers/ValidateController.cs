using MVCCourseW1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCourseW1.Controllers
{
    public class ValidateController : Controller
    {
        // GET: Validate
        public ActionResult Index()
        {
            return View();
        }



        public JsonResult CheckContactEmail(int 客戶Id,string Email)
        {
            bool isValidate = false;
            客戶資料Entities db = new 客戶資料Entities();
            var data = db.客戶聯絡人.Where(p => p.客戶Id == 客戶Id && p.Email == Email);
            isValidate = data.Count() == 0;

 
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }
    }
}