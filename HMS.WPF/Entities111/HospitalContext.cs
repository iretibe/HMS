using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace HMS.WPF.Entities
{
    public class HospitalContext : DbContext
    {
        public HospitalContext() : base("name=HospitalEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<AppointmentPatient> AppointmentPatients { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Medicine> Medicine { get; set; }
        public virtual DbSet<Nurse> Nurses { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<ResidentPatient> ResidentPatients { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder modelBuilder)
        //{
        //    //modelBuilder.UseSqlServer("Server=codelearnersoft.net;Database=PersolPosDb;user id=sa;password=YEso!@12;Trusted_Connection=False;MultipleActiveResultSets=true;TrustServerCertificate=True");

        //    base.OnConfiguring(modelBuilder);
        //}
    }
}
