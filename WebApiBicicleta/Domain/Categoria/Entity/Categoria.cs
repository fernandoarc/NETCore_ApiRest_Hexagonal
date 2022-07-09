using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Categoria.Entity
{
    public class Categoria
    {
        [Key]
        public int IdBicicletaCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Modelo.Entity.Modelo> BicicletaModelo { get; set; }
    }
}
