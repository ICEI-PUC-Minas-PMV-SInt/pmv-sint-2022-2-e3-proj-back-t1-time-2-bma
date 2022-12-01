using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace banco_alimentos.Models
{
    [Table("Beneficiarios")]
    public class Beneficiario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o CPF!")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o nome!")]
        public string Nome { get; set; }

        public ICollection<Doacao> Doacoes { get; set; }
    }
}