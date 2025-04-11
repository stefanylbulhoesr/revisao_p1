using revisao_p1.Domain;
using revisão_p1.Repositories;

namespace revisao_p1.Services
{
    public class AlunoServices : IAlunoServices
    {
        public AlunoServices(IAlunoRepositories alunorepositories) {
            _repository = alunorepositories;
        }
        
        private readonly IAlunoRepositories _repository;
        public void Atualizar(int id, string nome, decimal nota)
        {
           var aluno = new AlunoDomain(nome, nota);
            _repository.Atualizar(id, aluno);
        }

        public AlunoDomain ObterAluno(int id)
        {
            return _repository.ObterAluno(id);
        }

        public List<AlunoDomain> ObterTodos()
        {
            return _repository.ObterTodos();
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }

        public void Salvar(string nome, decimal nota)
        {
            var aluno = new AlunoDomain(nome, nota);
            _repository.Salvar(aluno);
        }
    }
}
