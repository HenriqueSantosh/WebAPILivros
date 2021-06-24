using Api.WebMusic.Data.Context;
using Api.WebMusic.Data.Implemantation;
using Api.WebMusic.Data.Repository;
using Api.WebMusic.Domain.Interfaces;
using Api.WebMusic.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Api.WebMusic.Crosscuting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IFaixaRepository, FaixaImplementation>();
            serviceCollection.AddScoped<IMidiaRepository, MidiaImplementation>();
            serviceCollection.AddScoped<IAlbumRepository, AlbumImplementation>();
            serviceCollection.AddScoped<IArtistaRepository, ArtistaImplementation>();
            serviceCollection.AddScoped<IGeneroRepository, GeneroImplementation>();


            serviceCollection.AddDbContext<MyContext>(
                  options => options.UseSqlServer(configuration.GetConnectionString("DB_CONNECTION")));
    
        }
    }
}
