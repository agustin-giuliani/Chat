namespace Chat.Data
{

    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Chat.Data.Entities;
    public class Repositorio
    {
        private readonly DataContext context;

        public Repositorio(DataContext context)
        {
            this.context = context;
        }

        public IEnumerable<Mensaje> GetMensajes()
        {
            return this.context.Mensajes.OrderBy(m => m.Enviado);
        }

        public Mensaje GetMensaje(int id)
        {
            return this.context.Mensajes.Find(id);
        }

        public void AddMensaje(Mensaje mensaje)
        {
            this.context.Mensajes.Add(mensaje);
        }

        public void UpdateMensaje(Mensaje mensaje)
        {
            this.context.Update(mensaje);
        }
        public void RemoveMensaje(Mensaje mensaje)
        {
            this.context.Mensajes.Remove(mensaje);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await this.context.SaveChangesAsync() > 0;
        }

        public bool MensajeExiste(int id)
        {
            return this.context.Mensajes.Any(m => m.Id == id);
        }

    }
}
