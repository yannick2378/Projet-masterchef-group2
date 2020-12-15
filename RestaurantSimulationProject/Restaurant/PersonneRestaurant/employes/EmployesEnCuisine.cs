using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.ToolsRestaurant.EnCuisine;

namespace Restaurant.PersonneRestaurant.employes
{
    public class EmployesEnCuisine : EmployesRestaurant
    {
        // les attributs propre a un employe en cuisine
        protected Dictionary<MaterielsDeCuisine,int> listOfMateriels;
        protected Dictionary<IngredientEnCuisine, int> listOfIngredients;

        // methodes qui permettent a un employe de cuisine d'interagir avec ses outils
        public EmployesEnCuisine()
        {
            listOfMateriels = null;
        }
        
        public void initialiserEmploye(Dictionary<MaterielsDeCuisine,int> listOfTools = null,Dictionary<IngredientEnCuisine,int> listofIngredients = null)
        {
            if(listOfTools != null)
            {
                this.listOfMateriels = listOfTools;
            }
            if(listofIngredients != null)
            {
                this.listOfIngredients = listofIngredients;
            }
        }
        public StatusDuTravail utilisationTools(int tempsOfWorking)
        {
            Dictionary<MaterielsDeCuisine,int>.KeyCollection myKeyCollection = listOfMateriels.Keys;// On recuperejuste les clefs
            Dictionary<IngredientEnCuisine, int>.KeyCollection mykeyCollection2 = listOfIngredients.Keys;

            this.statutDuTravail = StatusDuTravail.WorkRunning;
            if(this.listOfMateriels == null && this.listOfIngredients == null)
            {
                return this.statutDuTravail = StatusDuTravail.NotWork;
            }
            else
            {
                if(this.listOfIngredients != null)
                {
                    foreach(KeyValuePair<IngredientEnCuisine,int> kvp in listOfIngredients)
                    {
                        kvp.Key.ingredientIsUsing(kvp.Value);
                    }
                }

                if (this.listOfMateriels != null)
                {
                    foreach (KeyValuePair<MaterielsDeCuisine, int> kvp in listOfMateriels)
                    {
                        kvp.Key.materielIsUsing(kvp.Value);
                    }
                }
            }
            return this.statutDuTravail = StatusDuTravail.WorkFinished;
        }

    }
}
