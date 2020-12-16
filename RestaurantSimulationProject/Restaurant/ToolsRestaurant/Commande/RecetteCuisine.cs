using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.ToolsRestaurant.EnCuisine;

namespace Restaurant.ToolsRestaurant.Recette
{
    class RecetteCuisine
    {
        // Attribut d'une recette
        private Dictionary<IngredientEnCuisine, int> listIngredientRecette;
        private Dictionary<MaterielsDeCuisine, int> listMaterielsRecette;
        int tempsExecutionRecette;

        // operation sur une recette
        public RecetteCuisine()
        {
            listIngredientRecette = null;
            listMaterielsRecette = null;
            tempsExecutionRecette = 0;
        }

        public void ajouterRecette(Dictionary<IngredientEnCuisine, int> lIR, Dictionary<MaterielsDeCuisine, int> lMR, int tmp)
        {
            this.listIngredientRecette = lIR;
            this.listMaterielsRecette = lMR;
            this.tempsExecutionRecette = tmp;
        }
    }
}
