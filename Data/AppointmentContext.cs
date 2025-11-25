using Microsoft.EntityFrameworkCore;
using nail_salon_appointment_api.Model;

namespace nail_salon_appointment_api.Data
{
    public class AppointmentContext : DbContext
    {
        public AppointmentContext(DbContextOptions<AppointmentContext> options) : base(options) { }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Salon> Salons { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
