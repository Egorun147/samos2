using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building riba = new Building("Ribazavod", 1000, 10000);
            Building arbuz = new Building("arbuzi", 3000, 23000);
            Building[] building = new Building[2] { riba, arbuz };
            building[0].DisplayInfo();
            building[1].DisplayInfo();
            Settlement Settlement = new Settlement("Astrakhan", 100000);
            Settlement.AddBuilding(arbuz);
            Settlement.AddBuilding(arbuz);
            Settlement.AddBuilding(arbuz);
            Settlement.AddBuilding(riba);
            Settlement.ShowBuildings();
            Console.WriteLine($"Общая производительность {Settlement.GetTotalProduction()}");
            GameManager gameManager = new GameManager(Settlement);
            gameManager.SimulationTime();


        }
    }
}
