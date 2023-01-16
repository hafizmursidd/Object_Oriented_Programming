using SolutionJuraganMobil.Repository;
using SolutionJuraganMobil.Summary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionJuraganMobil.Base
{
    internal interface IRepositoryManager
    {
        public ISUVRepository Suv { get; }
        public ITaxiRepository Taxi { get; }

        public IPrivateJetRepository PrivateJet { get; }

        public IInfoSummary Summary { get; }  

    }
}
