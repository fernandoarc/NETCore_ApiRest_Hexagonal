using System.ComponentModel.DataAnnotations;

namespace Domain.Bicicleta.Entity
{
    public class Bicicleta
    {
        [Key]
        public int IdBicicleta { get; set; }
        public int IdBicicletaModelo { get; set; }
        public Modelo.Entity.Modelo Modelo { get; set; }
        public string Serial { get; set; }
        public bool Vigente { get; set; }
    }
}
