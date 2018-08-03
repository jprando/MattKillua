using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.Domain.Geral
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public string NascionalidadeMasculina { get; set; }
        public string NascionalidadeFeminina { get; set; }
        public string Continente { get; set; }
        public int DDI { get; set; }
        public DateTime CadastradoEm { get; set; }
        public DateTime AlteradoEm { get; set; }
        public DateTime ExcluidoEm { get; set; }
    }
}
