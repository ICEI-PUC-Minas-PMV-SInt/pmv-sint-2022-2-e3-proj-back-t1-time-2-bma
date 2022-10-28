
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cadastro_beneficiario.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório informar o nome!")]
        [Display(Name="Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o perfil!")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Admin,
        User,
        Benef
    }
}
