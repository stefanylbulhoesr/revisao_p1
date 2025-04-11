using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using revisao_p1.Domain;
using revisao_p1.Services;

namespace revisao_p1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoServices _services;
        public AlunoController(IAlunoServices alunoservice)
        {
            _services = alunoservice;
        }
        [HttpGet]
        public IActionResult ObterTodos()
        {
            var alunos = _services.ObterTodos();
            return Ok(alunos);
        }
        [HttpGet("{id}")]
        public IActionResult ObterAluno(int id)
        {
            var aluno = _services.ObterAluno(id);
            return Ok(aluno);
        }
        [HttpPost]
        public IActionResult Salvar([FromBody] AlunoDTO alunodto)
        {
            _services.Salvar(alunodto.Nome, alunodto.Nota);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Remover(int id)
        {
            _services.Remover(id);
            return Ok();
        }

        [HttpPatch]
        public IActionResult Atualizar(AlunoDomain alunodomain)
        {
            _services.Atualizar(alunodomain.id, alunodomain.Nome, alunodomain.Nota);
            return Ok();
        }
    }
}
