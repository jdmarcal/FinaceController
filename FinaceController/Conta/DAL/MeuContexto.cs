﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Conta.DAL
{
    class MeuContexto : DbContext
    {
        public MeuContexto() : base("strConn")
         {
 
         }
    }
}
