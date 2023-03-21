using Chapter.Models;
using Chapter.Repositores;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chapter.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LivroControllers : ControllerBase
    {
        private readonly LivroRepository _livroRepository;
        public LivroControllers(LivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return ok(_livroRepository.Ler());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        
       
        }

        private IActionResult ok(List<Livro> livros)
        {
            throw new NotImplementedException();
        }
    }
}
