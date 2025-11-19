using WebAPIGereciamentoDeLivroAutor.Models;

namespace WebAPIGereciamentoDeLivroAutor.services.Autor
{
    public class AutorService : IAutorInterface // respeita a IAutorInterface, todas as regras definidas nela devem ser implementadas aqui
    {
        public Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idlivro)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<AutorModel>>> ListarAutorores()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<AutorModel>> ObterAutorPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
