using BLL.Models;

namespace BLL
{
    public interface IUslugaService
    {
        public IEnumerable<UslugaDTO> Get();
        public UslugaDTO GetById(int id);
        public void Post(UslugaPostDTO uslugaPostDTO);
    }
}
