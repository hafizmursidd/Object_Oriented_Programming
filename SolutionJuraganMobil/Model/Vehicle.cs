using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionJuraganMobil.Model
{
    internal abstract class Vehicle
    {
        private String _noPolice;
        private int _year;
        private decimal _price;
        private decimal _tax;
        private int _seat;
        private DateOnly _transaction;
        private decimal _total;

        protected Vehicle(string noPolice, int year, decimal price, int seat, DateOnly transaction)
        {
            _noPolice = noPolice;
            _year = year;
            _price = price;
            _tax = price*0.1M;
            _seat = seat;
            _transaction = transaction;
        }

        public String NoPolice { get=> _noPolice; set=> _noPolice = value; }
        public int Year { get => _year; set=>_year=value; }
        public decimal Price { get => _price; set=>_price=value; }
        public decimal Tax { get => _tax; set => _tax = value; }
        public int Seat { get => _seat; set => _seat = value; }
        public DateOnly Transaction { get => _transaction;set=> _transaction = value; }
        public decimal Total { get => _total;set=> _total=value; }


        
    }
}
