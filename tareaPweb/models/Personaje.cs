using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tareaPweb.models
{
    public class Personaje
    {
        public int PersonajeId { get; set; }

        [Required(ErrorMessage = "El campo Nombre es requerido.")]
        public string Nombre { get; set; } = string.Empty;

        public string Alias { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo Rol es requerido.")]
        [StringLength(50, ErrorMessage = "El campo Rol no puede tener más de 50 caracteres.")]
        public string Rol { get; set; } = string.Empty;

        public string HabilidadEspecial { get; set; } = string.Empty;

        public string ArmaFavorita { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo Nivel Poder es requerido.")]
        [Range(1, 100, ErrorMessage = "El Nivel Poder debe estar entre 1 y 100.")]
        public int NivelPoder { get; set; }

        [Required(ErrorMessage = "El campo Imagen Personaje es requerido.")]
        [Url(ErrorMessage = "El campo Imagen Personaje debe ser una URL válida.")]
        public string ImagenPersonaje { get; set; } = string.Empty;
    }

}