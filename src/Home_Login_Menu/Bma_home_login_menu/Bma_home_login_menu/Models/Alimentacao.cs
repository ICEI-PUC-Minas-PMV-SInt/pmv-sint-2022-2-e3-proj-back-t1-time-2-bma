using Microsoft.EntityFrameworkCore;
namespace Bma_home_login_menu.Models
{
    public class Alimentacao
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Funcionarios.Any())
                {
                    return;
                }
                context.Funcionarios.AddRange
                (
                new Funcionario
                {
                    
                    Cpf = "123456",
                    Nome = "Maria Auxiliadora",
                    Data_nascimento = "1981-1-09",
                    Email = "jose@mixmail.com",
                    Telefone = "45692307",
                    Cep = "00000-000",
                    Logradouro = "Rua Camilo Santana",
                    Numero = "21",
                    Complemento = "Casa",
                    Bairro = "Alvorada",
                    Cidade = "Nowhere",
                    Uf = "Mg",
                    Situacao = "Ativo",
                    Perfil_acesso = Perfil.Admin,
                    Senha = "123"
                },
                new Funcionario
                {

                    Cpf = "456789",
                    Nome = "José Roberto",
                    Data_nascimento = "1982-1-09",
                    Email = "jose@mixmail.com",
                    Telefone = "45692307",
                    Cep = "00000-000",
                    Logradouro = "Rua Camilo Santana",
                    Numero = "21",
                    Complemento = "Casa",
                    Bairro = "Alvorada",
                    Cidade = "Nowhere",
                    Uf = "Mg",
                    Situacao = "Ativo",
                    Perfil_acesso = Perfil.User,
                    Senha = "123"
                }

                );
                context.SaveChanges();
            }
        }
    }
}
