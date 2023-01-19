using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionJuraganMobil.OOP
{
    internal class SUV : VehicleBase
    {
        public SUV(string noPolice, VehicleType vehicleType, DateTime transactionDate, double rent, double driverfee = 0) : base(noPolice, vehicleType, transactionDate, rent)
        {
            DriverFee = driverfee;
            TotalIncome = (decimal)(Rent + DriverFee);
        }

        public double DriverFee { get; set; }

        public override string ToString()
        {
            return base.ToString() +
                $"Order        : {Rent}\n" +
                $"Order PerKM  : {DriverFee}\n" +
                $"Total Income : {TotalIncome}\n";
        }
    }
}
