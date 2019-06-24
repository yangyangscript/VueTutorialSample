using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VueTutorialSample.Controllers
{
    public class VueSampleController : Controller
    {
        public ActionResult HellowVue()
        {
            return View();
        }

        //v-if 来确定元素是否显示
        public ActionResult IfVue()
        {
            return View();
        }

        //v-for 循环
        public ActionResult ForVue()
        {
            return View();
        }

        public ActionResult HandlerVue()
        {
            return View();
        }
    }
}