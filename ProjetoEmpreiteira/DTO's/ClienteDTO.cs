﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoEmpreiteira.Model;

namespace ProjetoEmpreiteira.DTO
{
    public class ClienteDTO
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }

        
    }
}
