using Microsoft.EntityFrameworkCore;
using Tecnicos.Data.Models;

namespace Tecnicos.Data.DAL
{
	public class TecnicosContext : DbContext
	{
		public TecnicosContext(DbContextOptions<TecnicosContext> Options)
		: base(Options) { }

		public DbSet<Clientes> Clientes { get; set; }
	}
}
