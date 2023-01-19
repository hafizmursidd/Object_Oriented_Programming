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
        List<PrivateJet> FindAll();

    }
}
