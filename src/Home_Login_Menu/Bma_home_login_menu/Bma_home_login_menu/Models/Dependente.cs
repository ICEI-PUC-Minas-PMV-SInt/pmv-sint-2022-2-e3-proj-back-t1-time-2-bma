using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bma_home_login_menu.Models
{
    [Table("Dependentes")]
    public class Dependente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name="Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        [Display(Name = "Data de Nascimento")]
        public DateTime Data_Nascimento { get; set; }

        [Display(Name ="Beneficiário")]
        public int BeneficiarioId { get; set; }
        [ForeignKey("BeneficiarioId")]
        public Beneficiario Beneficiario { get; set; }


    }
}
