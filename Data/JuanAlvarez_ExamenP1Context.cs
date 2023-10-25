using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JuanAlvarez_ExamenP1.Models;

namespace JuanAlvarez_ExamenP1.Data
{
    public class JuanAlvarez_ExamenP1Context : DbContext
    {
        public JuanAlvarez_ExamenP1Context (DbContextOptions<JuanAlvarez_ExamenP1Context> options)
            : base(options)
        {
        }

        public DbSet<JuanAlvarez_ExamenP1.Models.JuanAlvarez_tabla> JuanAlvarez_tabla { get; set; } = default!;
    }
}
