using System.Collections.Generic;
using System.Web.Mvc;
using FitnessClub.Models;

namespace FitnessClub.Controllers
{
    public class TrainersController : Controller
    {
        // GET: Trainers
        public ActionResult Trainers()
        {
            List<Trainer> trainers = new List<Trainer>();
            Trainer trainer = new Trainer();
            trainer.Name = "Robert Njonjo";
            trainer.Active = true;
            trainer.Shift = "evening";
            trainer.ShiftTime = "10:00";
            trainer.Email = "trainer@gmail.com";
            trainers.Add(trainer);
            return View(trainers);
        }
        public ActionResult RecordAttendance()
        {
            return View();
        }
        
    }
}