using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmesDBWPF.Models
{
    [Table("Filmes")]
    class Filme
    {
        [Key]
        public int FilmeId { get; set; }

        public string Titulo { get; set; }

        public double Nota { get; set; }

    }
}
