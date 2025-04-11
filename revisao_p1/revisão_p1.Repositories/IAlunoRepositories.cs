using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using revisao_p1.Domain;

namespace revisão_p1.Repositories
{
    internal interface IAlunoRepositories
    {
        void Salvar(AlunoDomain aluno);
        void Remover(int id);
        void Atualizar(int id, AlunoDomain aluno);
        AlunoDomain ObterAluno(int id);

        List<AlunoDomain> ObterTodos();
        
    }
}
