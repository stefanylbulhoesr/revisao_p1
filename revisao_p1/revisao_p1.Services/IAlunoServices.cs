using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using revisao_p1.Domain;

namespace revisao_p1.Services
{
    internal interface IAlunoServices
    {
        void Salvar(string nome, decimal nota);

        void Remover(int id);

        void Atualizar(int id,  string nome, decimal nota);

        List<AlunoDomain> ObterTodos();

        AlunoDomain ObterAluno(int id);
    }
}
