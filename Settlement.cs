using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace samos2
{
    internal class Settlement
    {
        Building[] buildings = new Building[5];
        private int budget;
        public bool Estlimesto(Building building)
        {
            for (int i = 0; i < buildings.Length; i++)
            {
                if (buildings[i] == null)
                {
                    return true;
                }
            }
            return false;
        }
        public bool Estlidengi(Building building)
        {
            if (budget >= building.BuildCost)
            {
                return true;
            }
            return false;
        }
        public void AddBuilding(Building building)
        {
            if (Estlidengi(building))
            {
                if (Estlimesto(building))
                {
                    for (int i =0; i < buildings.Length; ++i)
                    {
                        if (buildings[i] == null)
                        {
                            budget -= building.BuildCost;
                            buildings[i] = building;
                            Console.WriteLine($"Вы построили {building.Name} ");
                            return;
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("нет свободных слотов");
                }
            }
            else
            {
                Console.WriteLine("недостаточно средств");
            }

        }
        public int GetTotalProduction()
        {
            int totalProduction = 0;
            for (int i = 0; i < buildings.Length; ++i)
            {
                if (buildings[i] != null)
                {
                    totalProduction += buildings[i].Production;
                }
            }
            return totalProduction;
        }
        private string name;
        public string Name
        {
            get { return name; }
        }
        public int Budget
        {
            get { return budget; }
        }
        public Settlement(string Name, int Budget)
        {
            this.name = Name;
            this.budget = Budget;
        }
        public void ShowBuildings()
        {
            for (int i = 0; i < buildings.Length; ++i)
            {
                if (buildings[i] != null)
                {
                    Console.WriteLine("==================");
                    buildings[i].DisplayInfo();
                }
            }
        }
    }
}
