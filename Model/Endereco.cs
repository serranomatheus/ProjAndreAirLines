﻿namespace Model
{
    public class Endereco
    {
        #region Propriedades
        public int Id { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Estado { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        #endregion
    }
}