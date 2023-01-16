using SolutionJuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionJuraganMobil.Repository
{
    internal interface ISUVRepository
    {
        SUV FindById(string Nopol);
        List<SUV> FindAll();
        List<SUV> Create(SUV suv);
        SUV Update(string id, SUV suv);
        int Delete(string id);
    }
}
