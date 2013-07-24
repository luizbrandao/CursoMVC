namespace CursoMVC.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string Twitter { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
        public string Observacao { get; set; }
    }
}