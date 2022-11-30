using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;

namespace banco_alimentos.Models
{
    [Table("Doacoes")]
    public class Doacao
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "CPF do Beneficiário")]
        [Required(ErrorMessage = "Obrigatório informar o beneficiário!")]
        public int BeneficiarioId { get; set; }
        [ForeignKey("BeneficiarioId")]
        [Display(Name = "CPF do Beneficiário")]
        public Beneficiario Beneficiario { get; set; }

        [Display(Name = "Tipo de Cesta")]
        [Required(ErrorMessage = "Obrigatório informar o tipo!")]
        public TipoCesta Tipo { get; set; }

        [Display(Name = "Data da Retirada")]
        [Required(ErrorMessage = "Obrigatório informar a data!")]
        public DateTime Data { get; set; }


    }

    public enum TipoCesta
    {
        Básica,
        Verde
    }
}
