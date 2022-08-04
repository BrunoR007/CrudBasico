using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Models
{
	public class Movies
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string Name { get; set; }
		public string ReleaseDate { get; set; }
		public Actors? Actors { get; set; }
	}
}

