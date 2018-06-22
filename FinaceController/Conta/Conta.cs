using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Conta
    {
        [Key]
        public int IdConta { get; set; }

        public string Descricao { get; set; }

        public string Vencimento { get; set; }

        public double Valor { get; set; }

        public string Tipo { get; set; }
    }
}
