using System.Collections.Generic;
using System.Web.Mvc;
using FitnessClub.Models;

namespace FitnessClub.Controllers
{
    public class MembersController : Controller
    {
        // GET: Members
        public ActionResult Members()
        {
            List<Member> members = new List<Member>();
            Member member = new Member();
            member.Name = "Robert";
            member.Email = "rknjonjo@gmail.com";
            member.Shift = "Evening";
            member.ShiftTime = "05:00 PM";
            members.Add(member);
            return View(members);
        }
        public ActionResult RequestShift()
        {
            
            return View();
        }
        public ActionResult RequestShiftTest()
        {

            return View();
        }

        public JsonResult AddMember(Shifts shifts)
        {

        }
    }
}