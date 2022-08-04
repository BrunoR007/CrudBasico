using Microsoft.EntityFrameworkCore;
using Filmes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmes.Repository
{
	public class FilmesContext : DbContext
	{
		public FilmesContext(DbContextOptions<FilmesContext> opcoes)
		 : base(opcoes)
		{

		}
		public DbSet<Movie> Movies { get; set; }
		public DbSet<Actor> Actors { get; set; }
	}
}

