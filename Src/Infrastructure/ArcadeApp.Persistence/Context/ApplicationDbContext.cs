using System;
using Microsoft.EntityFrameworkCore;
using ArcadeApp.Domain.Entities;

namespace ArcadeApp.Persistence.Context
{
	public class ApplicationDbContext:DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
		{

		}


		public DbSet<Character> Characters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

			modelBuilder.Entity<Character>().HasData(

				new Character {  Name="TestCharacter", Defense=19,  HitPoints=2, Intelligence=89, Strength=25, Id = Guid.NewGuid() }

				) ;

            base.OnModelCreating(modelBuilder);
        }
    }
}

