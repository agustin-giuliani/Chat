using System;
using System.ComponentModel.DataAnnotations;

namespace Chat.Data.Entities
{
    public class Usuario
    {

        public int Id { get; set; }
        [Display (Name = "Nombre de Usuario")]
        public string NombreUsuario { get; set; }
        [Display(Name = "Ultimo Acceso")]
        public DateTime UltimoAcceso { get; set; }
        public string UrlAvatar { get; set; }
        public string CorreoElectronico  { get; set; }

    }
}