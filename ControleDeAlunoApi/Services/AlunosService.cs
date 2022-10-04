using ControleDeAlunoApi.Context;
using ControleDeAlunoApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeAlunoApi.Services
{
    public class AlunosService : IAlunosService
    {
        private readonly AppDbContext _context;

        public AlunosService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Alunos>> GetAlunos()
        {
            try
            {
                return await _context.Aluno.ToListAsync();

            }
            catch
            {
                throw;
            }
        }
        public async Task<IEnumerable<Alunos>> GetAlunosByNome(string nome)
        {
            IEnumerable<Alunos> alunos;
            if (!string.IsNullOrEmpty(nome))
            {
                alunos = await _context.Aluno.Where(n => n.Nome.Contains(nome)).ToListAsync();
            }
            else
            {
                alunos = await GetAlunos();
            }
            return alunos;
        }

        public async Task<Alunos> GetAlunos(int alunoId)
        {
            var aluno = await _context.Aluno.FindAsync(alunoId);
            return aluno;
        }
        public async Task CreateAlunos(Alunos alunos)
        {
            _context.Aluno.Add(alunos);
            await _context.SaveChangesAsync();

        }
        public async Task UpdateAlunos(Alunos alunos)
        {
            _context.Entry(alunos).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAlunos(Alunos alunos)
        {
            _context.Aluno.Remove(alunos);
            await _context.SaveChangesAsync();
        }

    }
}
