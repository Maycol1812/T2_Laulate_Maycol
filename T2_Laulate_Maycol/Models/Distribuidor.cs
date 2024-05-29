using System.ComponentModel.DataAnnotations;


namespace T2_Laulate_Maycol.Models
{
    public class Distribuidor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de Distribuidor es obligatorio")]
        public string NombreDistribuidor { get; set; }

        [Required(ErrorMessage = "La razon social es obligatorio")]
        public string RazonSocial { get; set; }

        [Required(ErrorMessage = "El telefono es obligatorio")]
        public int Telefono { get; set; }

        [Required(ErrorMessage = "El Año de inicio es obligatorio")]
        [Range(1900, 3000, ErrorMessage = "El año debe ser entre 1 y 3000")]
        public int AnioInicioOperacion { get; set; }

        [Required(ErrorMessage = "El contacto es obligatorio")]
        public string Contacto { get; set; }
    }
}
