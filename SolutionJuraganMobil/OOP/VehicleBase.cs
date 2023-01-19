using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionJuraganMobil.OOP
{
    internal abstract class VehicleBase 
    {
        protected VehicleBase(string? noPolice, VehicleType vehicleType, DateTime transactionDate)
        {
            NoPolice = noPolice;
            VehicleType = vehicleType;
            TransactionDate = transactionDate;
        }

        protected VehicleBase(string noPolice, VehicleType vehicleType, DateTime transactionDate, double rent)
        {
            NoPolice = noPolice;
            VehicleType = vehicleType;
            TransactionDate = transactionDate;
            Rent = rent;
        }

        public String? NoPolice { get; set; }
        public VehicleType VehicleType { get; set; }    
        public String? Year { get; set; }
        public double Price { get; set; }
        public float Tax { get; set; }
        public  int Seat { get; set; }
        public DateTime TransactionDate { get; set; }
        public double Rent { get; set; }
        public decimal TotalIncome { get; set; }

        public override string ToString()
        {
            return
                $"No Police         : {NoPolice}\n" +
                $"Type              : {VehicleType}\n" +
                $"Transaction Date  : {TransactionDate}\n";
        }
    }
    
}
