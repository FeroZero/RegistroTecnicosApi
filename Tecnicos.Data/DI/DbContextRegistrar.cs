using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tecnicos.Data.DAL;

namespace Tecnicos.Data.DI
{
	public static class DbContextRegistrar
	{
		public static IServiceCollection RegisterDbContextFactory(this IServiceCollection services)
		{
			services.AddDbContextFactory<TecnicosContext>(o => o.UseSqlServer("Name=SqlConStr"));
			return services;
		}
	}
}
