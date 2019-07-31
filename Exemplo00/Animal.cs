﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo00

{
    [Table("animais")]
    public class Animal
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("extinto")]
        public bool Extinto { get; set; }
        //[Column("peso")]
        //public bool Peso { get; set; }

        //[NotMapped]
        //public decimal IMC {get;set;}
    }
}
