using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExercicioSem4.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        public List<Autor> Autores { get; set; }
        public int CategoriaId { get; set; }
        public string lsbn { get; set; }
        public string Titulo { get; set; }
        public int preco { get; set; }
        public DateTime DataPublicação { get; set; }
        public int NumeroExemplares { get; set; }
        public Categoria Categoria { get; set; }
        public Autor Autor { get; set; }
        public List<Requisicao> Requisicoes { get; set; }



    }
}