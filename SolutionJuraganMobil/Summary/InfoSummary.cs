using SolutionJuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionJuraganMobil.Summary
{
    internal class InfoSummary : IInfoSummary

    {
        public int GetTotalVehicle()
        {
            int totalVehicle = Taxi.Count() + SUV.Count() + PrivateJet.Count();

            return totalVehicle;
        }
        public decimal GetTotalIncomePrivateJet()
        {
            return PrivateJet.IncomePrivateJet();
        }

        public decimal GetTotalIncomeSUV()
        {
            return SUV.IncomeSUV();
        }

        public decimal GetTotalIncomeTaxi()
        {
            return Taxi.IncomeTaxi();
        }

        public decimal GetTotalIncomeVehicle()
        {
            decimal totalIncomeVehicle = Taxi.IncomeTaxi() + PrivateJet.IncomePrivateJet() + SUV.IncomeSUV();

            return totalIncomeVehicle;
        }

        public int GetTotalSUV()
        {
            throw new NotImplementedException();
        }


    }
}
