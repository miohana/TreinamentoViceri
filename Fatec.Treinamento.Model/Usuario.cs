using Fatec.Treinamento.Model.Extensoes;

namespace Fatec.Treinamento.Model
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public bool Ativo { get; set; }

        public string CEP { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public int Pontos { get; set; }
        
        /// <summary>
        /// Retorna a senha criptografada.
        /// OBS: a propriedade SENHA deve ter sido informada.
        /// </summary>
        public string HashSenha
        {
            get
            {
                return Senha.GerarHash();
            }
        }

        public Perfil Perfil { get; set; }

    }
}
