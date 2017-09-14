using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExercicioSem4.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Descricao { get; set; }
        public List<Livro> Livros { get; set; }
    }
}