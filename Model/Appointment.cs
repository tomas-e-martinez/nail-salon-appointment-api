namespace nail_salon_appointment_api.Model
{
    public class Appointment
    {
        public int Id { get; set; }
        public required int CustomerId { get; set; }
        public required Customer Customer { get; set; }
        public required int SalonId { get; set; }
        public required Salon Salon { get; set; }
        public required DateTime DateTime { get; set; }
    }
}
