using SolutionJuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionJuraganMobil.Repository
{
    internal class TaxiRepository : ITaxiRepository

    {
        private List<Taxi> _taxi;

        public TaxiRepository()
        {
            _taxi = new List<Taxi> {
            new Taxi("D 11 UK", 2002, 175_000_000M, 4, new DateOnly(2023, 01, 12), 45, 4_500M),
            new Taxi("D 12 UK", 2015, 225_000_000M, 4, new DateOnly(2023, 01, 13), 75, 4_500M),
            new Taxi("D 13 UK", 2020, 275_000_000M, 4, new DateOnly(2023, 01, 13), 90, 4_500M)
            };
        }
        public Taxi FindById(string Nopol)
        {
            var TaxiNopol = _taxi.Find(s=>s.NoPolice.Equals(Nopol));

            if (TaxiNopol != null)
            {
                return TaxiNopol;

            }
            else return null;
        }
        public List<Taxi> FindAll()
        {
            return _taxi;
        }
        public List<Taxi> Create(Taxi taxi)
        {
            throw new NotImplementedException();
        }

        public int delete(string Nopol)
        {
            throw new NotImplementedException();
        }



        public Taxi Update(string Nopol, Taxi taxi)
        {
            throw new NotImplementedException();
        }
    }
}
