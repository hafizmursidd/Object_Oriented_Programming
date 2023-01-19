using SolutionJuraganMobil.OOP.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionJuraganMobil.OOP
{
    internal interface IVehicleFactory
    {
        public SUV CreateSUV(VehicleStruct vhStruct);

        public Taxi Createtaxi(VehicleRecord vhRecord);

        public void DisplayVehicle<T> (List<T> listVehicle);

        public int GetTotalVehicle<T>(List<T> listVehicle, VehicleType vhType);
    }
}
