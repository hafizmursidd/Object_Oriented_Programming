using SolutionJuraganMobil.Base;
using SolutionJuraganMobil.Model;
using SolutionJuraganMobil.Repository;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

       
        static void Main(string[] args)
        {

            var RepoManager = new RepositoryManager();

            var IPrivateJetRepo = new PrivateJetRepository();
            IPrivateJetRepo.FindAll();



            var fetchAllJet = RepoManager.PrivateJet.FindAll();
            var fetchAllSuv = RepoManager.Suv.FindAll();
            var fetchAllTaxi = RepoManager.Taxi.FindAll();


            var TotalVehicle = RepoManager.Summary.GetTotalVehicle();
            Console.WriteLine("Total Vehicle\t\t: " + TotalVehicle);

            var TotalSUV = RepoManager.Summary.GetTotalSUV();
            Console.WriteLine("Total Vehicle (SUV)\t: " + TotalSUV);

            var totalIncomeSUV = RepoManager.Summary.GetTotalIncomeSUV();
            string resultSUV = totalIncomeSUV.ToString("N");
            Console.WriteLine("Total Income SUV \t: " + resultSUV);

            var totalIncomeTaxi = RepoManager.Summary.GetTotalIncomeTaxi();
            string resultTaxi = totalIncomeTaxi.ToString("N");
            Console.WriteLine("Total Income Taxi \t: "+resultTaxi);


            var totalIncomeJet = RepoManager.Summary.GetTotalIncomePrivateJet();
            string resultPrivateJet = totalIncomeJet.ToString("N");
            Console.WriteLine("Total Income Jet \t: " + resultPrivateJet);

            var totalIncomeVehicle = RepoManager.Summary.GetTotalIncomeVehicle();
            string resultVehicle = totalIncomeVehicle.ToString("N");
            Console.WriteLine("Total Vehicle \t\t: " + resultVehicle);













            //var find = RepoManager.Suv.FindById("D 1001 UM");
            //Console.WriteLine(find);

            //var find = RepoManager.Taxi.FindById("D 11 UK");
            //Console.WriteLine(find);

            //var find = RepoManager.PrivateJet.FindById("ID8089");
            //Console.WriteLine(find);

            //foreach (var item in fetchAll)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in fetchAllSuv)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in fetchAllTaxi)
            //{
            //    Console.WriteLine(item);
            //}

            //var nopol = "D 1001 UM";
            //int deleted = RepoManager.Suv.Delete(nopol);
            //var result = Convert.ToBoolean(deleted) ? "Succesfully" : "Didn't Match";

            //Console.WriteLine($"Deleted Nopol \"{nopol}\" {result}");


            //var newTaxi = RepoManager.Suv.Create(
            //              new SUV("BD 111 CC", 2012, 12_000_000, 4, new DateOnly(2023, 11, 10), 200_000, 50_000));
            //foreach (var item in newTaxi)
            //{
            //    Console.WriteLine(item);
            //}


            //var totalIncome = RepoManager.Summary.GetTotalIncomeVehicle();
            //string result = totalIncome.ToString("N");
            //Console.WriteLine(result);


        }
    }
}