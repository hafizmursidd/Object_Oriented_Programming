using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionJuraganMobil.Model
{
    internal class Taxi : Vehicle

    {
        public static decimal _totalIncome;
        static int _count;
        private int _order;
        private decimal _OrderPerKM;
        private decimal _total;

        public Taxi(string noPolice, int year, decimal price, int seat, DateOnly transaction, int order, decimal orderPerKM) : base(noPolice, year, price, seat, transaction)
        {
            _order = order;
            _OrderPerKM = orderPerKM;
            _total = Order * OrderPerKM;
            _totalIncome += _total;
            _count++;
        }

        public int Order { get => _order; set => _order = value; }
        public decimal OrderPerKM { get => _OrderPerKM; set => _OrderPerKM = value; }

        public static int Count()
        {
            return _count;
        }

        public static decimal IncomeTaxi()
        {
            return _totalIncome;
        }

        public override string? ToString()
        {
            return
                $"No Police       :{NoPolice}" +
                $"\nVehicle Type    :Taxi" +
                $"\nYear            :{Year}" +
                $"\nPrice           :{Price}" +
                $"\nTax             :{Tax}        " +
                $"\nOrder           :{Order}     " +
                $"\nOrderPerKm      :{OrderPerKM}   " +
                $"\nTotal           :{Total}\n\n";
        }

    }
}
