using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace projetoWebPedal.Models
{
    [Table("RoteiroUsuarios")]
    public class RoteiroUsuario
    {
        [Key]
        public int Id { get; set; }

        public int RoteiroId { get; set; }
        [ForeignKey("RoteiroId")]

        public Roteiro Roteiro { get; set; }

        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

        public int Peso { get; set; }

    }
}
