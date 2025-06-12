using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class UslugaDTO
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Wykonawca { get; set; }
        public string Rodzaj { get; set; }
        public int Rok { get; set; }
    }
}
