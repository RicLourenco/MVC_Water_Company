using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Water_Company.Models
{
    public class Locality
    {
        [Key]
        public int LocalityID { get; set; }

        [Display(Name = "Locality")]
        [Required(ErrorMessage = "Required field")]
        public string Name { get; set; }

        [Display(Name = "Zip code")]
        [Required(ErrorMessage = "Required field")]
        public string ZipCode { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}