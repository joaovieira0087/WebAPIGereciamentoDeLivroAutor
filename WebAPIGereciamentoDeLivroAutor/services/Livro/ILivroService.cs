using WebAPIGereciamentoDeLivroAutor.Dto.Autor;
using WebAPIGereciamentoDeLivroAutor.Dto.Livro;
using WebAPIGereciamentoDeLivroAutor.Models;

namespace WebAPIGereciamentoDeLivroAutor.services.Livro
{
    public interface ILivroService
    {
        Task<ResponseModel<List<LivroModel>>> ListarLivros();
        Task<ResponseModel<List<LivroModel>>> AdiconarLivro(LivroCriacaoDto livroCriacaoDto);
        Task<ResponseModel<List<LivroModel>>> ExcluirLivro(int idlivro);
        
    }
}
