using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Marca.Entity
{
    public class Marca
    {
        [Key]
        public int IdBicicletaMarca { get; set; }
        public string Nombre { get; set; }
        public bool Vigente { get; set; }
        protected internal List<Modelo.Entity.Modelo> BicicletaModelo { get; set; }
    }
}
