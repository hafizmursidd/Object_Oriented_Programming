using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionJuraganMobil.Summary
{
    internal interface IInfoSummary
    {
        int GetTotalVehicle();
        int GetTotalSUV();
        decimal GetTotalIncomeSUV();
        decimal GetTotalIncomeTaxi();
        decimal GetTotalIncomePrivateJet();
        decimal GetTotalIncomeVehicle();
    }
}
