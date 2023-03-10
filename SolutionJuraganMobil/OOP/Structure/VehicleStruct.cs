using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionJuraganMobil.OOP.Structure
{
    internal struct VehicleStruct
    {
        public String? NoPolice { get; set; }
        public VehicleType VehicleType { get; set; }
        public DateTime TransactionDate { get; set; }
        public double Rent { get; set; }
        public double DriverFee { get; set; }
    }
}
