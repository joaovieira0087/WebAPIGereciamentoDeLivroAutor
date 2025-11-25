using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIGereciamentoDeLivroAutor.Models;
using WebAPIGereciamentoDeLivroAutor.services.Autor;

namespace WebAPIGereciamentoDeLivroAutor.Controllerss
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorControllers : ControllerBase
    {
        private readonly IAutorInterface _autorInterface;
        public AutorControllers(IAutorInterface autorInterface)
        {
            _autorInterface = autorInterface;
        }

        [HttpGet("ListarAutores")]

        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ListarAutores()
        {
            var autores = await _autorInterface.ListarAutorores();
            return Ok(autores);
        }

        [HttpGet("ObterAutorPorId/{id}")]
        public async Task<ActionResult<ResponseModel<AutorModel>>> BuscarAutorPorId(int IdAutor)
        {
            var autor = await _autorInterface.BuscarAutorPorId(IdAutor);
            return Ok(autor);
        }

        [HttpGet("BuscarAutorPorIdLivro/{idlivro}")]
        public async Task<ActionResult<ResponseModel<AutorModel>>> BuscarAutorPorIdLivro(int idlivro)
        {
            var autor = await _autorInterface.BuscarAutorPorIdLivro(idlivro);
            return Ok(autor);
        }
    }
}
