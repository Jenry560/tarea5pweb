
using System.ComponentModel.DataAnnotations;

namespace tareaPweb.models
{
    public class Plataforma
    {
        public int PlataformaId { get; set; }
        [Required(ErrorMessage = "El campo nombre es requerido.")]
        public string? Nombre { get; set; }
        public bool Estado { get; set; } = false;
    }

}