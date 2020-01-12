using Interface_VCENTER.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interface_VCENTER.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<vmStatus> fakeListOfVm = new List<vmStatus>()
            {
                new vmStatus("vm1", "192.168.0.1", true, DateTime.UtcNow, true),
                new vmStatus("vm2", "192.168.0.2", true, DateTime.UtcNow.AddDays(-2), true),
                new vmStatus("vm3", "192.168.0.3", false, DateTime.UtcNow.AddHours(-47), true),
                new vmStatus("vm4", "192.168.0.4", false, DateTime.UtcNow.AddDays(-48), true)
            };

            return View(fakeListOfVm);
        }
    }
}