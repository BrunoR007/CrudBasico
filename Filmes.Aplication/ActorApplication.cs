using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filmes.Models;
using Filmes.Repository;

namespace Filmes.Aplication
{
    public class ActorApplication
    {
        private readonly ActorRepository _actorRepository;

        public ActorApplication(ActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }

        public List<Actor> GetAll()
        {
            return _actorRepository.GetAll();
        }
        public Actor GetActor(int id)
        {
            Actor ActorExists = _actorRepository.GetActorById(id);

            if (ActorExists != null)
                return ActorExists;
            else
                throw new Exception("Ator não encontrado!");
        }

        public void InsertActor(Actor actor)
        {
            if(actor != null)
                _actorRepository.SaveActor(actor);
            else
                throw new Exception("Ator com nome ja existente!");
        }

        public void UpdateActor(Actor actor, int id)
        {
            Actor actorExists = _actorRepository.GetActorById(id);

            if (actorExists != null)
            {
                actorExists.Name = actor.Name;
                actorExists.Age = actor.Age;
                actorExists.MovieId = actor.MovieId;
 
                _actorRepository.UpdateActor(actorExists);
            }
            else
            {
                throw new Exception("Ator não pode ser atualizado");
            }
        }

        public void DeleteActor(int id)
        {
            Actor actorDelete = _actorRepository.GetActorById(id);

            if (actorDelete != null)
                _actorRepository.DeleteActor(actorDelete);
            else
                throw new Exception("Ator não encontrado");
        }

    }
}
