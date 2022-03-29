using System;

namespace Model
{
    public class Passageiro
    {
        #region Propriedades

        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; } 

        #endregion
    }
}
