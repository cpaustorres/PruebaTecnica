using System.ComponentModel.DataAnnotations.Schema;

namespace Pruebalocal.Models
{
    [Table("Vehiculos")]
    public class VehicleViewModel
    {
        // Propiedades
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Potencia { get; set; }
        public string Categoria { get; set; }
        public int UsuarioId { get; set; }
    }
}