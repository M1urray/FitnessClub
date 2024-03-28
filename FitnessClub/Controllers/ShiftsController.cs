using System.Collections.Generic;
using System.Web.Mvc;
using FitnessClub.Models;

namespace FitnessClub.Controllers
{
    public class ShiftsController : Controller
    {
        // GET: Shifts
        public ActionResult Shifts()
        {
            List<Shifts> shifts =new List<Shifts>();
            Shifts shift = new Shifts();
            shift.Shift = "evening";
            shift.ShiftTime = "05:00 PM";
            shift.Trainer = "Robert Njonjo";
            shifts.Add(shift);
            return View(shifts);
        }
    }
}