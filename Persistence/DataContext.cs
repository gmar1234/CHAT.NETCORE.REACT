using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        // CREAMOS EL CONSTRUCTOR PARA ENVIAR A LAS DEMAS CLAES
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Channel> Channels { get; set; }

    }
}
