﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinalEntra21.Models
{
    public class JWTConfig
    {
        public string Key {  get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }
}
