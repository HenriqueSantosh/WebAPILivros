using Api.WebMusic.Domain.Interfaces.Services;
using Api.WebMusic.Domain.Repository;
using Api.WebMusic.Services.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.WebMusic.Crosscuting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IFaixaService, FaixaService>();
            serviceCollection.AddTransient<IMidiaServices, MidiaService>();
            serviceCollection.AddTransient<IGeneroService , GeneroService>();


        }
    }
}
