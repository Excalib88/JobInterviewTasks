using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressionEngine
{
    public static class ServiceCollectionExt
    {
        public static IServiceCollection AddTokenServices(this IServiceCollection services)
        {
            return services
                .AddSingleton<ITokenService, TokenService>()
                .AddTransient<Tokenizer>();
        }
    }
}
