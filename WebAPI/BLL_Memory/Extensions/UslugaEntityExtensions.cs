using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BLL_Memory.Extensions
{
    internal static class UslugaEntityExtensions
    {
        public static UslugaDTO ToDTO (this UslugaEntity uslugaEntity)
        {
            return new UslugaDTO
            {
                Nazwa = uslugaEntity.Nazwa,
                Wykonawca = uslugaEntity.Wykonawca,
                Rodzaj = uslugaEntity.Rodzaj,
                Id = uslugaEntity.Id,
                Rok = uslugaEntity.Rok
            };
        }
    }
}
