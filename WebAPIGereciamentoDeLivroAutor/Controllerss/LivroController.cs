using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIGereciamentoDeLivroAutor.Models;
using WebAPIGereciamentoDeLivroAutor.services.Autor;
using WebAPIGereciamentoDeLivroAutor.services.Livro;

namespace WebAPIGereciamentoDeLivroAutor.Controllerss
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroService _LivroInterface;

        public LivroController(ILivroService livroInterface)
        {
            _LivroInterface = livroInterface;
        }


        [HttpGet("ListaLivros")]

        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ListarLivros()
        {
            var livros = await _LivroInterface.ListarLivros();
            return Ok(livros);
        }
    }
}
