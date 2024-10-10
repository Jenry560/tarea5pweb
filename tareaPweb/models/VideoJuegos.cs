using System.ComponentModel.DataAnnotations;

namespace tareaPweb.models
{
    public class VideoJuegos
    {

        public int VideoJuegoId { get; set; }

        [Required(ErrorMessage = "El campo Nombre es requerido.")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo Desarrollador es requerido.")]
        public string Desarrollador { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo Genero es requerido.")]
        public string Genero { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo FechaLanzamiento es requerido.")]
        public DateTime FechaLanzamiento { get; set; }

        [Required(ErrorMessage = "El campo ImagenPortada es requerido.")]
        [Url(ErrorMessage = "El campo ImagenPortada debe ser una URL válida.")]
        public string ImagenPortada { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo Descripcion es requerido.")]
        public string Descripcion { get; set; } = string.Empty;


        [Required(ErrorMessage = "El campo Plataforma es requerido.")]
        public string PlataformaId { get; set; } = string.Empty;
        public Plataforma Plataforma { get; set; } = new Plataforma();
    }
}