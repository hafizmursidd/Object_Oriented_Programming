using SolutionJuraganMobil.Repository;
using SolutionJuraganMobil.Summary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionJuraganMobil.Base
{
    internal class RepositoryManager : IRepositoryManager
    {
        private ISUVRepository _suv;
        private ITaxiRepository _taxi;
        private IPrivateJetRepository _privateJet;
        private IInfoSummary _summary;

        public ISUVRepository Suv {
            get
            {
                if (_suv is null)
                    _suv = new SUVRepository();

                return _suv;
            }

        }

        public ITaxiRepository Taxi
        {
            get
            {
                if (_taxi is null)
                    _taxi = new TaxiRepository();

                return _taxi;
            }

        }

        public IPrivateJetRepository PrivateJet
        {
            get
            {
                if (_privateJet is null)
                    _privateJet = new PrivateJetRepository();

                return _privateJet;
            }

        }

        public IInfoSummary Summary
        {
            get { 
            
                if(_summary is null)
                    _summary = new InfoSummary();

                return _summary;           
            
            }                
         }
    }
}
