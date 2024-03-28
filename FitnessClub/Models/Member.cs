using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FitnessClub.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey()]
        public Trainer TrainerId  { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Shift { get; set; }
        public string Email { get; set; }
        public string ShiftTime { get; set; }
    }
}