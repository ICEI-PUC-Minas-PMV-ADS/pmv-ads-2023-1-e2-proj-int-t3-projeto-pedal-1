using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace projetoWebPedal.Models
{
    [Table("Proponentes")]
    public class Proponente : Usuario
    {

        public ICollection<Roteiro> Roteiros { get; set; }
    }


}
