using System;
using System.Collections.Generic;

namespace AppJuegos.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Juegos = new HashSet<Juego>();
        }

        public int CategoriaId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Juego> Juegos { get; set; }
    }
}
