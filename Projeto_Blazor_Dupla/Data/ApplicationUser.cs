using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Projeto_Blazor_Dupla.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public DbSet<Cliente> ObjCliente { get; set; }
        public DbSet<Remedio> ObjRemedio { get; set; }
        public DbSet<Pedido> ObjPedido { get; set; }
    }

}
