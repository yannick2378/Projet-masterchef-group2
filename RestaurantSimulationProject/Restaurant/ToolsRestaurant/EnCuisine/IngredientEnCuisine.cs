using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ToolsRestaurant.EnCuisine
{
     public class IngredientEnCuisine
    {
        private string name;
        protected static int quantite;
        protected UsingState stateOfIngredient;

        // methodes
        public IngredientEnCuisine()
        {
            stateOfIngredient = UsingState.NotToUse;
        }
        public void createIngredient(string name, int quantiteUse)
        {
            this.name = name;
            quantite = quantiteUse;
        }
        public void ingredientIsUsing(int quantiteUsed)
        {
            this.stateOfIngredient = UsingState.Using;
            if (quantite != 0)
            {
                quantite -= quantiteUsed;
            }
            else
            {
                //attendre que un materiels se libere
            }
        }
        public void ingredientFinishToUse()
        {
            this.stateOfIngredient = UsingState.FinishedToUSe;
        }
        public void rechargerIngredient(int quantiteRecharged)
        {
            quantite += quantiteRecharged;
        }
    }
}
