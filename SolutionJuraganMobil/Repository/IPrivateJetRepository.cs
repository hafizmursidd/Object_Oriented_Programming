using SolutionJuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionJuraganMobil.Repository
{
    internal interface IPrivateJetRepository
    {
        PrivateJet FindById(String Nopol);
        List<PrivateJet> FindAll();
        List<PrivateJet> Create(PrivateJet taxi);
        PrivateJet Update(string Nopol, PrivateJet taxi);
        int delete(string Nopol);
    }
}
