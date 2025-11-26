using System.Text.Json.Serialization;
using WebAPIGereciamentoDeLivroAutor.Models;

namespace WebAPIGereciamentoDeLivroAutor.Dto.Livro
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }
        public int  Id { get; set; }
    }
}
