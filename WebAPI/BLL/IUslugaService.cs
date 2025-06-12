using BLL.Models;

namespace BLL
{
    public interface IUslugaService
    {
        public IEnumerable<UslugaDTO> Get();
        public UslugaDTO GetById(int id);
        public void Post(UslugaPostDTO uslugaPostDTO);
        public void delete(int id);
        public void put(int id, UslugaDTO uslugaDTO);
    }
}
