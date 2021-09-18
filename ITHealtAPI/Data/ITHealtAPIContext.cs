using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ITHealtAPI.Models;

namespace ITHealtAPI.Data
{
    public class ITHealtAPIContext : DbContext
    {
        public ITHealtAPIContext (DbContextOptions<ITHealtAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ITHealtAPI.Models.Paciente> Table_pacientes { get; set; }
    }
}
