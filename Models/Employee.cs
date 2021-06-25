using System;
using System.ComponentModel.DataAnnotations;

namespace Workday.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Display(Name = "Imię")]
        public string Name { get; set; }


        [Display(Name = "Data urodzenia")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Stanowisko")]
        public string Position { get; set; }
        [Display(Name = "Wynagrodzenie")]
        public decimal Salary { get; set; }
        [Display(Name = "Pesel")]
        public long PersonalId { get; set; }
    }
}