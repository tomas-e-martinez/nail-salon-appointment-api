namespace nail_salon_appointment_api.Model
{
    public class Salon
    {
        public int Id { get; set; }
        public required int OwnerId { get; set; }
        public required User Owner { get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required decimal Latitude { get; set; }
        public required decimal Longitude { get; set; }
    }
}
