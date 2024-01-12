using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    [Table("Departaments ", Schema = "usuEstudo")]
    public class Departaments
    {   
        [Key]
        public int DepartamentsId { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório !!!")]
        public string Name { get; set; }

        public virtual ICollection <City> Cities{ get; set; }

    }
}