using SolutionJuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionJuraganMobil.Repository
{
    internal interface ITaxiRepository
    {
        Taxi FindById(String Nopol);
        List<Taxi> FindAll();
        List <Taxi> Create (Taxi taxi);
        Taxi Update (string Nopol, Taxi taxi);  
        int delete(string Nopol);

    }
}
