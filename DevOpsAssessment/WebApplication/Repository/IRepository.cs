using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Repository
{
    public interface IRepository
    {
        List<Superhero> Get();
        Superhero GetByID(int id);
    }
}
