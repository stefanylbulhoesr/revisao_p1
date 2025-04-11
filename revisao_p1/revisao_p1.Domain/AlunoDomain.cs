namespace revisao_p1.Domain
{
    public class AlunoDomain
    {
        public string Nome { get; set; }
        public decimal Nota { get; set; }

        public int id { get; set; }
        public AlunoDomain(string nome, decimal nota) { 
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentNullException("Nome nulo ou em branco");
            }
            if (nota > 10 || nota < 0) {
                throw new ArgumentException("Nota inválida");
            }
            Nome = nome;
            Nota = nota;

        }
    }
}
