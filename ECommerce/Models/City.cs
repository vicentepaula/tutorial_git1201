using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    [Table("City ", Schema = "usuEstudo")]
    public class City
    {
       
        [Key]
        public int CityId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório !!!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório !!!")]
        public int DepartamentsId { get; set; }


        public virtual Departaments Departament { get; set; }

    }
}