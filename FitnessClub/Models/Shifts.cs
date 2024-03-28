using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitnessClub.Models
{
    public class Shifts
    {
        [Key]
        public int Id { get; set; }
        public string Trainer { get; set; }
        public string Shift { get; set; }
        public string ShiftTime { get; set; }
    }
}