using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace ControleFinanceiro.API.Extensions
{
    public static class ConfiguracaoIdentityExtension
    {
        public static void ConfigurarSenhaUsuario(this IServiceCollection services)
        {
            services.Configure<IdentityOptions>(opcoes =>
            {
                opcoes.Password.RequireDigit = false;               //Não precisa de digito
                opcoes.Password.RequireLowercase = false;           //Não precisa ser apenas letras minusculas
                opcoes.Password.RequiredLength = 6;                 //Tamanho minimo
                opcoes.Password.RequireNonAlphanumeric = false;     //Não precisa de alphanumericos
                opcoes.Password.RequireUppercase = false;           //Não precisa ser apenas letras maiusculas
                opcoes.Password.RequiredUniqueChars = 0;            //Numero máximo de caracteres unicos
            });
        }
    }
}
