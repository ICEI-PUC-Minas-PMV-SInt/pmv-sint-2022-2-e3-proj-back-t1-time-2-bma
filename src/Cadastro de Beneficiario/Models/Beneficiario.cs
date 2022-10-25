using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Cadastro de Beneficiário")]
public class Beneficiario
{
	[Key]
	public int Id_Beneficiario { get; set; }
	[Required(ErrorMessage ="Campo obrigatório!")]
	public string CPF { get; set; }

    [Required(ErrorMessage = "Campo obrigatório!")]
    public string Nome_Beneficiario { get; set; }

    [Required(ErrorMessage = "Campo obrigatório!")]
    public string Situacao { get; set; }

    [Required(ErrorMessage = "Campo obrigatório!")]
    public DateTime Data_Nascimento { get; set; }

    [Required(ErrorMessage = "Campo obrigatório!")]
    public string CEP { get; set; }

    [Required(ErrorMessage = "Campo obrigatório!")]
    public string Logradouro { get; set; }

    [Required(ErrorMessage = "Campo obrigatório!")]
    public string Numero { get; set; }

	public string Complemento { get; set; }

    [Required(ErrorMessage = "Campo obrigatório!")]
    public string Cidade { get; set; }

    [Required(ErrorMessage = "Campo obrigatório!")]
    public string UF { get; set; }

    
}
