using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBookStore.Controllers
{
    public class SachController : Controller
    {
        private SachRepository sachRepository;

        public SachController()
        {
            string connectionString = "DESKTOP-9KJ6S3P";
            sachRepository = new SachRepository(connectionString);
        }

        public ActionResult XoaSach(int maSach)
        {
            sachRepository.XoaSach(maSach);

          

            return View();
        }
    }

}