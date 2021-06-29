using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicZone4.Models
{
    public class Banda
    {
        [Required(ErrorMessage = "Digite o nome da banda.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o número de elementos")]
        public int? Elementos { get; set; }

        public string Genero { get; set; }

        public bool TOP { get; set; }
    }
}