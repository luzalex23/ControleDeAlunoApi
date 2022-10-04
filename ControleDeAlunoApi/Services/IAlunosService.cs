using ControleDeAlunoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeAlunoApi.Services
{
    public interface IAlunosService
    {
        Task<IEnumerable<Alunos>> GetAlunos();
        Task<Alunos> GetAlunos(int alunoId);
        Task<IEnumerable<Alunos>> GetAlunosByNome(string nome);

        Task CreateAlunos(Alunos alunos);
        Task UpdateAlunos(Alunos alunos);
        Task DeleteAlunos(Alunos alunos);



    }
}
