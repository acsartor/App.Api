﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entidade
{
    public class Pessoa
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Peso { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Ativo {  get; set; }
    }
}
