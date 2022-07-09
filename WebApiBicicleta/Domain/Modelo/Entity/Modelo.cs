using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Marca.Entity;
using Domain.Categoria.Entity;

namespace Domain.Modelo.Entity
{
    public class Modelo
    {
        [Key]
        public int IdBicicletaModelo { get; set; }
        public string Nombre { get; set; }
        public int Anio { get; set; }
        public int IdBicicletaMarca { get; set; }
        public Marca.Entity.Marca Marca { get; set; }
        public int IdBicicletaCategoria { get; set; }
        public Categoria.Entity.Categoria Categoria { get; set; }
        public List<Bicicleta.Entity.Bicicleta> Bicicleta { get; set; }
    }
}
