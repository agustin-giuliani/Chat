namespace Chat.Data.Entities
{


    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    public class Mensaje
    {
        public int id { get; set; }

        [Display(Name = "Enviado")]
        public DateTime enviado { get; set; }

        [Display(Name = "Mensaje")]
        public string mensaje { get; set; }

        [Display(Name = "Emisor")]
        public Usuario usuarioEmisor { get; set; }

        [Display(Name = "Receptor")]
        public Usuario usuarioReceptor { get; set; }


        [Display(Name = "Grupo")]
        public int idGrupo { get; set; }





    }



}