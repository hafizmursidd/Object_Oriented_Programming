using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionJuraganMobil.OOP
{
    internal class Jet : VehicleBase
    {
        public Jet(string noPolice, VehicleType vehicleType, DateTime transactionDate, double rent, double orderPerHour) : base(noPolice, vehicleType, transactionDate, rent)
        {
            OrderPerHour = orderPerHour;
        }


        public double OrderPerHour { get; set; }

        public override string ToString()
        {
            return base.ToString() +
               // $"Order        : {Order}\n" +
                $"Order PerHours: {OrderPerHour}\n" +
                $"Total Income : {TotalIncome}\n";
        }
    }
}
