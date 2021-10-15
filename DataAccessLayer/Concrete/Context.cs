using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Authority> Authorities { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Mail> Mails { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Staff> Staffs { get; set; }
    }
}
