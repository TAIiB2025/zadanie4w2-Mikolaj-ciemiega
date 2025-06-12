namespace DAL.Entities
{
    public class UslugaEntity
    {
        public int Id { get; set; }
        public  required string Nazwa { get; set; }
        public required string Wykonawca { get; set; }
        public required string Rodzaj {  get; set; }
        public required int Rok {  get; set; }
    }
}
