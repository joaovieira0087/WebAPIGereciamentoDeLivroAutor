using WebAPIGereciamentoDeLivroAutor.Dto.Autor;
using WebAPIGereciamentoDeLivroAutor.Dto.Livro;
using WebAPIGereciamentoDeLivroAutor.Models;

namespace WebAPIGereciamentoDeLivroAutor.services.Livro
{
    public interface ILivroService
    {
        Task<ResponseModel<List<LivroModel>>> ListarLivros();
        Task<ResponseModel<LivroModel>> BuscarLivroPorId(int livroId);
        Task<ResponseModel<List<LivroModel>>> BuscarLivroPorIdAutor(int AutorId);
        Task<ResponseModel<List<LivroModel>>> AdiconarLivro(LivroCriacaoDto livroCriacaoDto);
        Task<ResponseModel<List<LivroModel>>> EditarLivro(LivroEdicaoDto livroEdicaoDto);
        Task<ResponseModel<List<LivroModel>>> ExcluirLivro(int idlivro);
        
    }
}
