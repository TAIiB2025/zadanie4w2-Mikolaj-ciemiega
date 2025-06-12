using BLL;
using BLL.Models;
using BLL_Memory.Extensions;
using DAL.Entities;
using static System.Net.Mime.MediaTypeNames;

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
            if (uslugaPostDTO.Nazwa.Length >= 100)
            {
                throw new ApplicationException($"nazwa nie może być dłuższa od 100, " +
                    $"było {uslugaPostDTO.Nazwa.Length}");
            }
            if (uslugaPostDTO.Rodzaj.ToLower() != "budowlana")
            {
                if (uslugaPostDTO.Rodzaj.ToLower() != "projektowa")
                {
                    if (uslugaPostDTO.Rodzaj.ToLower() != "edukacyjna")
                    {
                        throw new ApplicationException($"nieprawidłowy rodzaj ={uslugaPostDTO.Rodzaj}");
                    }
                }
            }
            if (uslugaPostDTO.Rok > 2025)
            {
                throw new ApplicationException($"nieprawidłowy rok ={uslugaPostDTO.Rok}");
            }

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
        public void delete(int id)
        {
            UslugaEntity test = uslugi.Find(us => us.Id == id);
            if (test == null)
            {
                throw new ApplicationException($"Nie znaleziono osoby o id ={id}");
            }
            uslugi.Remove(test);
        }
        public void put(int id, UslugaDTO uslugaDTO)
        {
            UslugaEntity test = uslugi.Find(us => us.Id == id);
            
            if (test == null)
            {
                throw new ApplicationException($"Nie znaleziono osoby o id ={id}");
            }
            if (uslugaDTO.Nazwa.Length>=100)
            {
                throw new ApplicationException($"nazwa nie może być dłuższa od 100, " +
                    $"było {uslugaDTO.Nazwa.Length}");
            }
            if(uslugaDTO.Rodzaj.ToLower() != " budowlana")
            {
                if (uslugaDTO.Rodzaj.ToLower() != " projektowa")
                {
                    if (uslugaDTO.Rodzaj.ToLower() != " edukacyjna")
                    {
                        throw new ApplicationException($"nieprawidłowy rodzaj ={uslugaDTO.Rodzaj}");
                    }
                }
            }
            if (uslugaDTO.Rok > 2025)
            {
                throw new ApplicationException($"nieprawidłowy rok ={uslugaDTO.Rok}");
            }
            uslugi.Remove(test);
            test.Nazwa=uslugaDTO.Nazwa;
            test.Wykonawca = uslugaDTO.Wykonawca;
            test.Rodzaj = uslugaDTO.Rodzaj;
            test.Rok=uslugaDTO.Rok;

            uslugi.Add(test);
        }
    }
}
