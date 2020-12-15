using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ToolsRestaurant.EnCuisine
{
    class RecetteDeCuisine
    {
        // attribut des recettes de cuisine
        private string name;
        private Dictionary<IngredientEnCuisine, int> ListOfIngredient;
        private Dictionary<MaterielsDeCuisine, int> ListeOfMaterielsForCook;
    }
}
