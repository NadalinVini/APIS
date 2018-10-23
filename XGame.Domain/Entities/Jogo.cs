using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame.Domain.Entities
{
    public class Jogo
    {
        public Guid Id { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public String Produtora { get; set; }
        public String Distribuidora { get; set; }
        public string Genero { get; set; }
        public String Site { get; set; }
    }
}
