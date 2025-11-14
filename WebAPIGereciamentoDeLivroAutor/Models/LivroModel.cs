using System.Text.Json.Serialization;

namespace WebAPIGereciamentoDeLivroAutor.Models
{
    public class LivroModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        [JsonIgnore]
        public AutorModel Autor { get; set; } 
    }
}
//UM LIVRO PODE TER APENAS UM AUTOR, MAS UM AUTOR PODE TER VÁRIOS LIVROS.