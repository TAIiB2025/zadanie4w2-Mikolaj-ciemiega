using BLL;
using BLL.Models;
using BLL_Memory.Extensions;
using DAL.Entities;

namespace BLL_Memory
{
    public class UslugaService:IUslugaService
    {
        private static int IdGen = 1;
        private static List<UslugaEntity> uslugi =
            [
                new UslugaEntity(){Id=IdGen++, Nazwa="AAA", 
                    Wykonawca="aaa", Rodzaj="111", Rok=111},
                new UslugaEntity(){Id=IdGen++, Nazwa="BBB",
                    Wykonawca="bbb", Rodzaj="222", Rok=222},
                new UslugaEntity(){Id=IdGen++, Nazwa="CCC",
                    Wykonawca="ccc", Rodzaj="333", Rok=333},
                new UslugaEntity(){Id=IdGen++, Nazwa="DDD",
                    Wykonawca="ddd", Rodzaj="444", Rok=444},
                new UslugaEntity(){Id=IdGen++, Nazwa="EEE",
                    Wykonawca="eee", Rodzaj="555", Rok=555},
            ];
        public IEnumerable<UslugaDTO> Get()
        {
            return uslugi.Select(u => u.ToDTO());
        }
        public UslugaDTO GetById(int id)
        {
            UslugaEntity? uslugaEntity=uslugi.Find(us=>us.Id==id);
            if (uslugaEntity == null)
            {
                throw new ApplicationException($"Nie znaleziono osoby o id ={id}");
            }
            return uslugaEntity.ToDTO();
        }
        public void Post(UslugaPostDTO uslugaPostDTO)
        {
            UslugaEntity uslugaEntity = new UslugaEntity
            {
                Id = IdGen++,
                Nazwa = uslugaPostDTO.Nazwa,
                Wykonawca = uslugaPostDTO.Wykonawca,
                Rodzaj = uslugaPostDTO.Rodzaj,
                Rok = uslugaPostDTO.Rok
            };
            uslugi.Add(uslugaEntity);
        }
    }
}
