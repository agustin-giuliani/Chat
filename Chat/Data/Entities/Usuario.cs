using System;

namespace Chat.Data.Entities
{
    public class Usuario
    {

        public int id { get; set; }
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }

        public DateTime fechaAlta { get; set; }
        public DateTime ultimoAcceso { get; set; }

        public string preguntaSecreta { get; set; }

        public string respuestaPregSecreta { get; set; }

    }
}