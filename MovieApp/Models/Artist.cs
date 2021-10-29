using System;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class Artist
    {
        public int Id { get; set; }


        [Display(Name = "First Name")]
        public string First_Name { get; set; }


        [Display(Name = "Last Name")]
        public string Last_Name { get; set; }


        [Display(Name = "Other Names")]
        public string Other_Names { get; set; }


        [Display(Name = "Cast Name")]
        public string Cast_Name { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime Date_of_Birth { get; set; }
    }
}
