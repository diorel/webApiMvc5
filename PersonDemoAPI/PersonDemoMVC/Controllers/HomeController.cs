using PersonDemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;

namespace PersonDemoMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<PersonModel> lst = new List<PersonModel>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:11714/");



            return View();
        }
    }
}