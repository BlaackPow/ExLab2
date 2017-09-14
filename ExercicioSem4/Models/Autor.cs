using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExercicioSem4.Models
{
    public class Autor
    {
        public int AutorId { get; set; }

        public List<Livro> Livros { get; set; }
    }
}