using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Pruebalocal.Models
{

    [Table("Usuarios")]
    public class UserViewModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nombre")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [JsonPropertyName("apellidos")]
        [MaxLength(100)]
        public string Apellidos { get; set; }

        [JsonPropertyName("dni")]
        [RegularExpression(@"\d{8}")]
        public string Dni { get; set; }

        [JsonPropertyName("carnet")]
        public string Carnet { get; set; }

        [JsonPropertyName("telefono")]
        public string Telefono { get; set; }

        [NotMapped] // Esta propiedad no se mapeará a la base de datos
        public List<UserViewModel> Usuarios { get; set; }
    }
}