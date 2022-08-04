using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filmes.Models;

namespace Filmes.Repository
{
    public class ActorRepository
    {
        private readonly FilmesContext _context;

        public ActorRepository(FilmesContext context)
        {
            _context = context;
        }

        public List<Actor> GetAll()
        {
            return _context.Actors.ToList();
        }

        public Actor GetActorById(int id)
        {
            return _context.Actors.FirstOrDefault(x => x.Id == id);
        }

        public void SaveActor(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public void UpdateActor(Actor actor)
        {
            _context.Actors.Update(actor);
            _context.SaveChanges();
        }

        public void DeleteActor(Actor actor)
        {
            _context.Actors.Remove(actor);
            _context.SaveChanges();
        }
    }
}
