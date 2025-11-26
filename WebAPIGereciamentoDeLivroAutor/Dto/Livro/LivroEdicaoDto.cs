using System.Text.Json.Serialization;
using WebAPIGereciamentoDeLivroAutor.Dto.Vinculo;
using WebAPIGereciamentoDeLivroAutor.Models;

namespace WebAPIGereciamentoDeLivroAutor.Dto.Livro
{
    public class LivroEdicaoDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
