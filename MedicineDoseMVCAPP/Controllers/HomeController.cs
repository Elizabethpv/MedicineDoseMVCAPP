using MedicineDoseMVCAPP.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicineDoseMVCAPP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult StudentView(Person person)
        {
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);

            con.Open();
            SqlCommand cmd = new SqlCommand("PersonTopView", con);
            cmd.CommandType = CommandType.StoredProcedure;

            return View("About", person);
        }

    }
}