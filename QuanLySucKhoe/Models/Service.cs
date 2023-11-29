using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySucKhoe.Models
{
    public class Service
        //dịch vụ
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        //kiểu dữ liệu tiền tệ
        public float Price { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Duration { get; set; }//khoảng thời gian

        [Required]
        [Display(Name = "Pavilion")]
        public int PavilionId { get; set; }
        public Pavilion Pavilion { get; set; }
    }
}
