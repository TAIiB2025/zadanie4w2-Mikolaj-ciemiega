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
        public IActionResult Post([FromBody] UslugaPostDTO o)
        {
            try {
                uslugaService.Post(o);
            }catch(Exception ex)
            {
                
                return StatusCode (500);
            }

            return StatusCode(200);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, UslugaDTO o)
        {
            try
            {
                uslugaService.put(id,o);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

            return StatusCode(200);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            uslugaService.delete(id);
        }

    }
    
}
