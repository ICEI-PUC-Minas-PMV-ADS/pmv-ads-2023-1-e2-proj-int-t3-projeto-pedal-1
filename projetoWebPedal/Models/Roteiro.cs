using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace projetoWebPedal.Models
{
    [Table("Roteiros")]
    public class Roteiro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Local!")]
        public string Local { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Ponto de Encontro!")]
        public string PontoEncontro { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Data e Horario!")]
        [Display(Name = "Data e Horário")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Distância em metros!")]
        public int Distancia { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Dificuldade!")]
        [Display(Name = "Grau de Dificuldade")]
        public Dificuldade Dificuldade { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Final { get; set; }

        public int ProponenteId { get; set; }

        [ForeignKey("ProponenteId")]
        public Proponente Proponente { get; set; }

        //public ICollection<RoteiroUsuario> RoteiroUsuarios { get; set; }

    }
    public enum Dificuldade
    {
        Um, Dois, Três, Quadro, Cinco
    }
}
