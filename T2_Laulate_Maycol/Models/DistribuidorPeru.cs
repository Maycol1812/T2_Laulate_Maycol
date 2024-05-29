using System.ComponentModel.DataAnnotations;

namespace T2_Laulate_Maycol.Models
{
    public class DistribuidorPeru
    {
        [Key]
        public int IdPeru { get; set; }
        public string NombreDistribuidorPeru { get; set; }
        public string RazonSocialPeru { get; set; }
        public int TelefonoPeru { get; set; }
        public int AnioInicioOperacionPeru { get; set; }
        public string ContactoPeru { get; set; }
    }
}
