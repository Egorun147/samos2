using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samos2
{
    internal class GameManager
    {
        private int gameTime = 60;
        Settlement settlement;
        public GameManager(Settlement settlement)
        {
            this.settlement = settlement;
        }
        public void SimulationTime()
        {
            Console.WriteLine($"За {gameTime} минут будет произведено {settlement.GetTotalProduction() * gameTime}");
        }

    }
}
