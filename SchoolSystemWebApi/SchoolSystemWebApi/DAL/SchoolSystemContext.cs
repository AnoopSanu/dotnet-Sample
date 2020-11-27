using Microsoft.EntityFrameworkCore;
using SchoolSystemWebApi.Models;

namespace SchoolSystemWebApi.DAL
{
    public class SchoolSystemContext : DbContext
    {
        public SchoolSystemContext(DbContextOptions<SchoolSystemContext> options):base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
    }
}
