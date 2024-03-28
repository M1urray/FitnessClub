using System.Web.Mvc;
using System.Web.Security;
using FitnessClub.DTOs;

namespace FitnessClub.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            Session.Remove("Username");
            Session.RemoveAll();
            FormsAuthentication.SignOut();
            Login user = new Login();
            return View(user);
        }
        [HttpPost]
        public JsonResult LoginUser(Login userlogin)
        {
            string msg = "";
            bool success = false;
            string UserName = userlogin.UserName.ToUpper();
            string passwrd = "password";
            return Json(new { message = msg, success = success }, JsonRequestBehavior.AllowGet);
        }
    }
}