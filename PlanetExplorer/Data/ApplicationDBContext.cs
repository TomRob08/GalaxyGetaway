using PlanetExplorer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PlanetExplorer.Data;

public class ApplicationDBContext : IdentityDbContext 
{
	public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
	{
	}

	public DbSet<Planet> Planets { get; set; }
}