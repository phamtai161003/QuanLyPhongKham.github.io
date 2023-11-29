using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QuanLySucKhoe.Models
{
    public class User
        //người dùng
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Surname { get; set; }

        [Required]
        [StringLength(255)]
        [Index(IsUnique = true)]
        public string Username { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Role")]
        public int RoleId { get; set; }
        public Role Role { get; set; }

        [Display(Name = "Pavilion")]
        public int? PavilionId { get; set; }
        public Pavilion Pavilion { get; set; }

        public List<Timetable> Timetables { get; set; }
    }

}
