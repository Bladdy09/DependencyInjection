using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Inyecciones.Models
{
    public partial class Region
    {
        public Region()
        {
            Territories = new HashSet<Territory>();
        }

        [Required(ErrorMessage = "favor de digital el numero de identifiacion de la region")]

        public int RegionId { get; set; }
        [Required(ErrorMessage ="Por favor llenar la descripcion")]
        public string RegionDescription { get; set; }

        public virtual ICollection<Territory> Territories { get; set; }
    }
}
