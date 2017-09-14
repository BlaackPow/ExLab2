using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExercicioSem4.Models
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Rua { get; set; }
        public int CEP { get; set; }
    }
}