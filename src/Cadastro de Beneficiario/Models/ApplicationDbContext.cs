using Microsoft.EntityFrameworkCore;
using System;

public class ApplicationDbContext: DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{
	}

	public DbSet <Beneficiario> Beneficiarios { get; set; }
}
