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

        //v-on:click @click
        public ActionResult HandlerVue()
        {
            return View();
        }

        //v-model 双向绑定
        public ActionResult IntPutMessage()
        {
            return View();
        }

        //1.prop传值 https://cn.vuejs.org/v2/guide/components-props.html
        //2.v-bind 动态赋值
        public ActionResult ComponentVue()
        {
            return View();
        }


    }
}