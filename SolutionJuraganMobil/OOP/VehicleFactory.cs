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
            return new SUV(vhStruct.NoPolice, vhStruct.VehicleType, vhStruct.TransactionDate, vhStruct.Rent, vhStruct.DriverFee) ;
        }
        public Taxi Createtaxi(VehicleRecord vhRecord)
        {
            return new Taxi(vhRecord.NoPolice, vhRecord.VehicleType, vhRecord.TransactionDate,  vhRecord.Order, vhRecord.OrderPerKM);
        }

        public void DisplayVehicle<T>(List<T> listVehicle)
        {
            listVehicle.ForEach(x => System.Console.WriteLine(x));
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
