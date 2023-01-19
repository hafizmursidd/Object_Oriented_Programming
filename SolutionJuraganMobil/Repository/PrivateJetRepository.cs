using SolutionJuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionJuraganMobil.Repository
{
    internal class PrivateJetRepository : IPrivateJetRepository
    {
        private List<PrivateJet> _privatejet;

        public PrivateJetRepository()
        {
            _privatejet = new List<PrivateJet> {
                new PrivateJet("ID8089", 2015, 150_000_000_000, 12, new DateOnly(2023, 01, 23), 35_000_000, 15_000_000),
                new PrivateJet("ID8089", 2015, 175_000_000_000, 15, new DateOnly(2023, 01, 25), 55_000_000, 25_000_000)
                };
        }
        public List<PrivateJet> FindAll()
        {
            return _privatejet;
        }
















        public PrivateJet FindById(string Nopol)
        {
            var PrivatJetNP = _privatejet.Find(s => s.NoPolice.Equals(Nopol));
            if (PrivatJetNP != null)
            {
                return PrivatJetNP;
            }
            else return null;

        }
        public List<PrivateJet> Create(PrivateJet taxi)
        {
            throw new NotImplementedException();
        }

        public int delete(string Nopol)
        {
            throw new NotImplementedException();
        }



        public PrivateJet Update(string Nopol, PrivateJet taxi)
        {
            throw new NotImplementedException();
        }
    }
}
