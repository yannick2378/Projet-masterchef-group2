using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace Restaurant.ToolsRestaurant
{
    public enum UsingState
    {
        NotToUse,
        Using,
        FinishedToUSe
    }
    class TimerRestaurant
    {
        // attribut principaux pour le chronometre de fonction
        private int timeStarter;
        private int timeEnder;
        private int intervale;

        // methode pour lancer et chronomtre et declencher une methode
        public TimerRestaurant()
        {
            timeStarter = 0;
            timeStarter = 0;
            intervale = 0;
        }

        public bool DemarrerChrono(int intervalSended, Action myMethode)
        {
            bool finished = false;
            private static System.Timers.Timer aTimer;


            return finished;
        }
    }
}
