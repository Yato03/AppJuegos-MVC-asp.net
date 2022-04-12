using System;
using System.Collections.Generic;

namespace AppJuegos.Models
{
    public partial class Juego
    {
        public int GameId { get; set; }
        public string Name { get; set; } = null!;
        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; } = null!;
    }
}
