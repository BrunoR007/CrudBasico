using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Filmes.Models
{
	public class Movie
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string Name { get; set; }
		public string ReleaseDate { get; set; }
	}
}

