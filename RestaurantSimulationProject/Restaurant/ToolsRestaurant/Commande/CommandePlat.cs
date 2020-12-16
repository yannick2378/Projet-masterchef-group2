using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ToolsRestaurant.Commande
{
    class CommandePlat
    {
        private int numeroDeTable;
        private List<int> entreeRecette;
        private List<int> resistanceRecette;
        private List<int> dessertRecette;

        // methode la classe commande 
        public CommandePlat()
        {
            numeroDeTable = 0;
            entreeRecette = null;
            resistanceRecette = null;
            dessertRecette = null;
        }
        
        public void prendreUneCommande(int nDT,List<int> eR, List<int> rR, List<int> dR)
        {
            numeroDeTable = nDT;
            entreeRecette = eR;
            resistanceRecette = rR;
            dessertRecette = dR;
        }
    }
}
