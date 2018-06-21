using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Conta
    {
        public int IdConta { get; set; }

        public string Descricao { get; set; }

        public string Vencimento { get; set; }

        public double Valor { get; set; }

        public string Tipo { get; set; }
    }
}
