using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bma_home_login_menu.Models
{
    [Table("Beneficiario")]
    public class Beneficiario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo Obrigatório")]
        [Display(Name="Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}")]
        [Display(Name="Data de Nascimento")]
        public DateTime Data_Nascimento { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Nº")]
        public string Numero { get; set; }        
        public string? Complemento { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string UF { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string CEP { get; set; }

        [Display(Name ="Cesta Básica")]
        public bool Cesta_basica { get; set; }
        [Display(Name="Cesta Verde")]
        public bool Cesta_Verde { get; set; }

        public ICollection<Dependente> Dependentes { get; set; }


    }
}
