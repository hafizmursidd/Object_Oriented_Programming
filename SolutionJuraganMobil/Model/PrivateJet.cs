using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionJuraganMobil.Model
{
    internal class PrivateJet : Vehicle

    {
        static decimal _totalIncome;
        static int _count;
        private decimal _rent;
        private decimal _driver;
        private decimal _total;

        public PrivateJet(string noPolice, int year, decimal price, int seat, DateOnly transaction, decimal rent, decimal driver) : base(noPolice, year, price, seat, transaction)
        {
            _rent = rent;
            _driver = driver;
            _total = rent + driver;
            _totalIncome += _total;
            _count++;
        }

        public decimal Rent { get => _rent; set => _rent = value; }
        public decimal Driver { get => _driver; set => _driver = value; }

        public static int Count()
        {
            return _count;
        }

        public static decimal IncomePrivateJet() {
            return _totalIncome;
        }
        public override string? ToString()
        {
            return
                $"No Police     : {NoPolice}    \nVehicle Type  :Private Jet \nYear          :{Year}     \nPrice         :{Price}" +
                $"\nTax           :{Tax}        \nRent          :{Rent}     \nDriver        :{Driver}   \nTotal         :{_total}\n\n";
        }
    }
}
