using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace projetoWebPedal.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Altura em centimetros!")]
        public int Altura { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Login!")]
        public string login { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Senha!")]
        //[DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Perfil!")]
        public Perfil Perfil { get; set; }

        //public ICollection<Roteiro> Roteiros { get; set; }

        //public ICollection<RoteiroUsuario> RoteiroUsuarios { get; set; }
    }

    public enum Perfil
    {
        Admin, Usuario, Proponente
    }
}
