using ControleDeAlunoApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeAlunoApi.Context
{
    public class AppDbContext : DbContext 
    
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    
     public DbSet<Alunos> Aluno { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alunos>().HasData(
                new Alunos
                {
                    AlunoId = 1,
                    Nome = "Antonio Carlos",
                    Email = "antoniocarlos@yahoo.com",
                    Idade = 22

                });
        }
    }
}
