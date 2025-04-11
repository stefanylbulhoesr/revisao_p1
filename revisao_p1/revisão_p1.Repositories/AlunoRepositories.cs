using revisao_p1.Domain;

namespace revisão_p1.Repositories
{
    public class AlunoRepositories : IAlunoRepositories
    {
        public AppDbContext _context;
        public AlunoRepositories(AppDbContext context)
        {
            _context = context;
        }

        public void Atualizar(int id, AlunoDomain aluno)
        {
            var alunos = ObterAluno(id);
            alunos.Nota = aluno.Nota;
            alunos.Nome = aluno.Nome;
            _context.SaveChanges();
        }

        public AlunoDomain ObterAluno(int id)
        {
            var aluno = _context.Alunos.FirstOrDefault(a => a.id == id);
            return aluno;
        }

        public List<AlunoDomain> ObterTodos()
        {
            return _context.Alunos.ToList();
        }

        public void Remover(int id)
        {
            var aluno = ObterAluno(id);
            _context.Remove(aluno);
            _context.SaveChanges();
        }

        public void Salvar(AlunoDomain aluno)
        {
            _context.Alunos.Add(aluno);
            _context.SaveChanges();
        }
    }
}
