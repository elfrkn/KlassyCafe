namespace KlassyCafe.DAL.Entities
{
    public class Rezervation
    {
        public  int RezervationId { get; set; }
        public  string Name { get; set; }
        public  string Email { get; set; }
        public  string Phone { get; set; }
        public  int  GuestNumber { get; set; }
        public  string Date { get; set; }
        public  string  Time { get; set; }
        public  string  Message { get; set; }
    }
}
