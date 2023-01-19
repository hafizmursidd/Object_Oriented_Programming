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

        public Taxi(string noPolice, VehicleType vehicleType, DateTime transactionDate, int order = 0, double orderperKM = 0) : base(noPolice, vehicleType, transactionDate)
        {
            Order = order;
            OrderPerKM = orderperKM;
            TotalIncome = (decimal) (Order * OrderPerKM);
        }
        public int Order { get; set; }
        public double OrderPerKM { get; set; }

        public override string ToString()
        {
            return base.ToString() +
                $"Order        : {Order}\n" +
                $"Order PerKM  : {OrderPerKM}\n" +
                $"Total Income : {TotalIncome}\n";
        }
    }
}
