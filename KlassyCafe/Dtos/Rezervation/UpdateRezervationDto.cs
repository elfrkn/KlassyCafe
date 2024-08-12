﻿namespace KlassyCafe.Dtos.Rezervation
{
    public class UpdateRezervationDto
    {
        public int RezervationId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int GuestNumber { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Message { get; set; }
    }
}
