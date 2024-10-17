using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDLL.DTO
{
    public class BreakdownDTO
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Breakdown Reference")]
        public string BreakdownReference { get; set; }
        [Display(Name = "Company Name ")]
        public string CompanyName { get; set; }
        [Display(Name = "Driver Name")]
        public string DriverName { get; set; }
        [Display(Name = "Registration Number")]
        public string RegistrationNumber { get; set; }
        [Display(Name = "Breakdown Date")]
        [DataType(DataType.Date)] 
        public DateTime BreakdownDate { get; set; }
    }

}
