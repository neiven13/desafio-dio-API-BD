using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio_api_bd.Entities;
using Microsoft.EntityFrameworkCore;

namespace desafio_api_bd.Context

{
    public class PlannerContext : DbContext
    {
        public PlannerContext(DbContextOptions<PlannerContext> options) : base(options)
        {
        }
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}