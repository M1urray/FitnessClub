using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FitnessClub.Models
{
    public class Trainer
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string Email { get; set; }
        public string Shift { get; set; }
        public bool Active { get; set; }
        public string ShiftTime { get; set; }
    }

    public class RecordAttendance
    {
        public string MemberId { get; set; }
        public string AttendanceDate { get; set; }
    }
}