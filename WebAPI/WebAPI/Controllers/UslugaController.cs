using BLL;
using BLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UslugaController : ControllerBase
    {
        private readonly IUslugaService uslugaService;
        public UslugaController(IUslugaService uslugaService)
        {
            this.uslugaService= uslugaService;
        }
        [HttpGet]
        public IEnumerable<UslugaDTO> Get()
        {
            return uslugaService.Get();
        }

        [HttpGet("{id}")]
        public UslugaDTO GetByID(int id)
        {
            return uslugaService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] UslugaPostDTO o)
        {
            uslugaService.Post(o);
        }

    }
    
}
