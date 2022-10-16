using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_banco_alimentos.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Cpf { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Nome { get; set; }

        [Required (ErrorMessage ="Campo obrigatório!")]
        public string Matricula { get; set; }

        [Required (ErrorMessage ="Campo obrigatório!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required (ErrorMessage ="Campo obrigatório!")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Admin,
        User
    }
}
