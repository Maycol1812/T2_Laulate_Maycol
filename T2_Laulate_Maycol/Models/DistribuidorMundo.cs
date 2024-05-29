using System.ComponentModel.DataAnnotations;

namespace T2_Laulate_Maycol.Models
{
    public class DistribuidorMundo
    {
        [Key]
        public int IdMundo { get; set; }
        public string NombreDistribuidorMundo { get; set; }
        public string RazonSocialMundo { get; set; }
        public int TelefonoMundo { get; set; }
        public int AnioInicioOperacionMundo { get; set; }
        public string ContactoMundo { get; set; }
    }
}
