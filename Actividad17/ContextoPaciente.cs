using Actividad_17.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Actividad17.Server.Contexto
{
    public class ContextoPaciente : DbContext
    {
        public ContextoPaciente(DbContextOptions<ContextoPaciente> options) : base(options)
        {
            
        }
        public DbSet<Paciente> pacientes { get; set; }
    }
}
