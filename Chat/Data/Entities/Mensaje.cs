namespace Chat.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Mensaje
    {
        public int Id { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Display(Name = "Enviado")]
        public DateTime Enviado { get; set; }
        [MaxLength(240)]
        [Display(Name = "Mensaje")]
        public string MensajeEnviado { get; set; }
        [Display(Name = "Emisor")]
        public Usuario UsuarioEmisor { get; set; }

       
    }


}