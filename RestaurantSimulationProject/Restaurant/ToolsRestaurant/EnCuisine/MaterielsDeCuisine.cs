using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ToolsRestaurant.EnCuisine
{
    public class MaterielsDeCuisine
    {
        // attribut des materiaux de cuisine
        private string name;
        protected static int quantite;
        protected UsingState etatDuMateriel;

        // methodes
        public MaterielsDeCuisine()
        {
            etatDuMateriel = UsingState.NotToUse;
        }
        public void createMateriels(string name,int quantiteUsed)
        {
            this.name = name;
            quantite = quantiteUsed;
        }
        public void materielIsUsing(int quantiteUsed)
        {
            this.etatDuMateriel = UsingState.Using;
            if(quantite != 0)
            {
                quantite -= quantiteUsed;
            }
            else
            {
                //attendre que un materiels se libere
            }
        }
        public void materielsFinishToUse(int quantiteUsed)
        {
            this.etatDuMateriel = UsingState.FinishedToUSe;
            quantite += quantiteUsed;
        }
        public void materielNotToUse()
        {
            this.etatDuMateriel = UsingState.NotToUse;
        }
    }
}
