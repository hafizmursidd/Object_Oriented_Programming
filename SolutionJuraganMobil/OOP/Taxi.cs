using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionJuraganMobil.OOP
{
    internal class Taxi : VehicleBase
    {
        public Taxi(string noPolice, VehicleType vehicleType, DateTime transactionDate, double rent, int order = 0, double orderperKM = 0) : base(noPolice, vehicleType, transactionDate, rent)
        {
            Order = order;
            OrderPerKM = orderperKM;
            TotalIncome = (decimal) (Order * OrderPerKM);
        }
        public int Order { get; set; }
        public double OrderPerKM { get; set; }
    }
}
