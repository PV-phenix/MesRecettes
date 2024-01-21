namespace MesRecettes.Models
{
    public class Recette
    {
        public int Id { get; set; }
        public required string Nom { get; set; }
        public int TemperatureDeCuisson { get; set; }
        public int TempsDeCuisson { get; set; }
        public string? Instructions { get; set; }
        public int TypeAlimentId { get; set; }
        public int OrigineAlimentId { get; set; }

        public virtual required TypeAliment TypeAliment { get; set; }
        public virtual required OrigineAliment OrigineAliment { get; set; }
        public virtual required ICollection<IngredientRecette> RecetteIngredients
        {
            get; set;
        }

    }
}

