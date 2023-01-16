using SolutionJuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionJuraganMobil.Repository
{
    internal class SUVRepository : ISUVRepository
    {

        private List<SUV> _suvs;

        public SUVRepository()
        {
            _suvs = new List<SUV> {
               new SUV("D 1001 UM", 2010, 35000_0000M, 4, new DateOnly(2023, 01, 10), 500000M, 150000M)
               ,new SUV("D 1002 UM", 2010, 350000000M, 4, new DateOnly(2023, 01, 10), 500000M, 150000M)
               ,new SUV("D 1003 UM", 2015, 350000000M, 5, new DateOnly(2023, 01, 12), 500000M, 150000M)
               ,new SUV("D 1004 UM", 2015, 350000000M, 5, new DateOnly(2023, 01, 13), 500000M, 150000M)
            };
        }

        public SUV FindById(string Nopol)
        {
            var SuvNopol = _suvs.Find(s=>s.NoPolice.Equals(Nopol));
            if (SuvNopol != null)
            {
                return SuvNopol;
            }
            else return null;
        }
        public List<SUV> FindAll()
        {
            return _suvs;
        }


        public int Delete(string id)
        {
            var SuvNopol = _suvs.Find(s => s.NoPolice.Equals(id));

            if (SuvNopol != null)
            {
                _suvs.Remove(SuvNopol);
                return 1;
            }
            else return 0;
        }
        public List<SUV> Create(SUV suv)
        {
            _suvs.Add(suv); 
            return FindAll();   
        }


        public SUV Update(string id, SUV suv)
        {
            var findSuv = FindById(id);
            var suvId = _suvs.FindIndex(s => s.NoPolice.Equals(id));

            if (findSuv != null) {
                findSuv.NoPolice = suv.NoPolice is null ? findSuv.NoPolice : suv.NoPolice;
                findSuv.Year = suv.Year.Equals(0) ? findSuv.Year : suv.Year;
                findSuv.Price = suv.Price.Equals(0) ? findSuv.Price : suv.Price;
                findSuv.Seat = suv.Seat.Equals(0) ? findSuv.Seat : suv.Seat;
                findSuv.Transaction = suv.Transaction.Equals(01 / 01 / 001) ? findSuv.Transaction : suv.Transaction;
                findSuv.Rent = suv.Rent.Equals(0) ? findSuv.Seat : suv.Rent;
                findSuv.Driver = suv.Driver.Equals(0) ? findSuv.Driver : suv.Driver;

                _suvs[suvId] = findSuv;
            }
            return findSuv;
        }
    }
}
