using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySucKhoe.Models
{
    public class EmergencyDoctor
    //bác sĩ
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
