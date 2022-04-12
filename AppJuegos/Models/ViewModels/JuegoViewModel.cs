using System.ComponentModel.DataAnnotations;

namespace AppJuegos.Models.ViewModels
{
    public class JuegoViewModel
    {
        [Required]
        [Display(Name="Nombre")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }
    }
}
