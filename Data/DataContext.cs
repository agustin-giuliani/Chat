using Microsoft.EntityFrameworkCore;
using Chat.Data.Entities;
namespace Chat.Data {

    using Microsoft.EntityFrameworkCore;
    using Chat.Data.Entities;
    public class DataContext : DbContext {
        //Para generar la tabla de Mensajes en la DB
        public DbSet<Mensaje> Mensajes { get; set; }
     
        public DataContext (DbContextOptions<DataContext> options) : base (options) {

        }
     
        public DbSet<Chat.Data.Entities.Usuario> Usuario { get; set; }
    }
}