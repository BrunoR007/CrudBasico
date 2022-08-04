using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filmes.Repository;
using Filmes.Models;

namespace Filmes.Aplication
{
    public class MovieApplication
    {
        private readonly MovieRepository _movieRepository;

        public MovieApplication(MovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public List<Movie> GetAll()
        {
            return _movieRepository.GetAll();
        }

        public Movie GetMovie(int id)
        {
            Movie movieExists = _movieRepository.GetMovieById(id);

            if (movieExists != null)
                return movieExists;
            else
                throw new Exception("Filme não encontrado!");
        }

        public void InsertMovie(Movie movie)
        {
            _movieRepository.SaveMovie(movie);
        }

        public void UpdateMovie(Movie movie, int id)
        {
            Movie movieExists = _movieRepository.GetMovieById(id);

            if (movieExists != null)
            {
                movieExists.Name = movie.Name;
                movieExists.ReleaseDate = movie.ReleaseDate;

                _movieRepository.UpdateMovie(movieExists);
            }
            else
            {
                throw new Exception("Filme não pode ser atualizado");
            }
        }

        public void DeleteMovie(int id)
        {
            Movie movieDelete = _movieRepository.GetMovieById(id);

            if (movieDelete != null)
                _movieRepository.DeleteMovie(movieDelete);
            else
                throw new Exception("Filme não encontrado");
        }
    }
}
