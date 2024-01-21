using System.ComponentModel.DataAnnotations.Schema;

namespace MesRecettes.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int UniteDeMesureId { get; set; }
        public string Quantite { get; set; }

        public virtual required UniteDeMesure UniteDeMesure { get; set; }
        public virtual ICollection<IngredientRecette> IngredientRecettes { get; set; }

    }
}
