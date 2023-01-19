using SolutionJuraganMobil.OOP.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionJuraganMobil.OOP
{
    internal class VehicleFactory : IVehicleFactory
    {
        public SUV CreateSUV(VehicleStruct vhStruct)
        {
            throw new NotImplementedException();
        }

        public SUV CreateTaxi(VehicleRecord vhRecord)
        {
            throw new NotImplementedException();
        }

        public void DisplayVehicle<T>(List<T> listVehicle)
        {
            throw new NotImplementedException();
        }

        public int GetTotalVehicle<T>(List<T> listVehicle, VehicleType vhType)
        {
            var result = 0;

            switch (vhType) 
            {
                case VehicleType.All:
                    result = listVehicle.Count;
                    break;
                case VehicleType.SUV:
                    result = listVehicle.OfType<VehicleBase>().Where(x => x.VehicleType == VehicleType.SUV).Count();
                    break;
                case VehicleType.TAXI:
                    result = listVehicle.OfType<VehicleBase>().Where(x => x.VehicleType == VehicleType.TAXI).Count();
                    break;
                case VehicleType.JET:
                    result = listVehicle.OfType<VehicleBase>().Where(x => x.VehicleType == VehicleType.JET).Count();
                    break;
                default:
                    Console.WriteLine("Didn't match");
                    break;
            }

            return result;
        }
    }
}
