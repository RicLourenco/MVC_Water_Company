using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Water_Company.Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }

        [Display(Name = "First names")]
        [Required(ErrorMessage = "Required field")]
        public string FirstNames { get; set; }

        [Display(Name = "Last names")]
        [Required(ErrorMessage = "Required field")]
        public string LastNames { get; set; }

        [Display(Name = "Birth date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Required field")]
        public DateTime BirthDate { get; set; }

        [NotMapped]
        public int Age
        {
            get
            {
                if (DateTime.Now.DayOfYear > BirthDate.DayOfYear)
                {
                    return DateTime.Now.Year - BirthDate.Year;
                }
                else
                {
                    return DateTime.Now.Year - BirthDate.Year - 1;
                }

            }
        }

        [Display(Name = "E-Mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Locality")]
        [Required(ErrorMessage = "Required field")]
        [Range(1, int.MaxValue, ErrorMessage = "Must select a {0}")]
        public int LocalityID { get; set; }

        public virtual Locality Locality { get; set; }
    }
}