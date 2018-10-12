using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Repository
{
    public class SuperheroRepository : IRepository
    {

        public List<Superhero> Get()
        {
            return PopulateHeros();
        }

        public Superhero GetByID(int id)
        {
            if (id == 0)
                return null;

            var results = PopulateHeros();
            return results.FirstOrDefault(s => s.SuperheroID == id);
        }

        public List<Superhero> PopulateHeros()
        {
            return new List<Superhero>()
            {
                new Superhero(){ SuperheroID = 1, SuperheroName = "Batman" },
                new Superhero(){ SuperheroID = 2, SuperheroName = "Joker" },
                new Superhero(){ SuperheroID = 3, SuperheroName = "Harley Quinn" },
                new Superhero(){ SuperheroID = 4, SuperheroName = "Wonder Woman" }
            };
        }
    }

}
