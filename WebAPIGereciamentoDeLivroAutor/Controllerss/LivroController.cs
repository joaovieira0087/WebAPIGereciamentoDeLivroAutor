using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIGereciamentoDeLivroAutor.Dto.Livro;
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

        [HttpPost("AdicionarLivro")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> AdiconarLivro(LivroCriacaoDto livroCriacaoDto)
        {
            var livroCriar = await _LivroInterface.AdiconarLivro(livroCriacaoDto);
            return Ok(livroCriar);
        }

        [HttpDelete("ExcluirLivro")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ExcluirLivro(int idlivro)
        {
            var ExcluirLivro = await _LivroInterface.ExcluirLivro(idlivro);
            return Ok(ExcluirLivro);
        }
    }
}
