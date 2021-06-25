using System;
using System.ComponentModel.DataAnnotations;

namespace Workday.Models
{
    public class VacationRequest
    {
        public int ID { get; set; }
        [Display(Name = "Imię")]
        public string Name { get; set; }


        [Display(Name = "Data złożenia wniosku")]
        [DataType(DataType.Date)]
        public DateTime DateOfRequest { get; set; }
        [Display(Name = "Od")]
        [DataType(DataType.Date)]
        public DateTime From { get; set; }
        [Display(Name = "Do")]
        [DataType(DataType.Date)]
        public DateTime To { get; set; }
        public Boolean status { get; set; }


        public object setStatus(Boolean status) {
            this.status = status;
            return status;
        }
    }
}