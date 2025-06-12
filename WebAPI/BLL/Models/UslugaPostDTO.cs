using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public record UslugaPostDTO(string Nazwa, 
        string Wykonawca, string Rodzaj, int Rok);
}
