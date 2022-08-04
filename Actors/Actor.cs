using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmes.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        [ForeignKey("FK_FilmesId")]
        public int MovieId { get; set; }  
        public Movie? Movie { get; set; }
    }
}
