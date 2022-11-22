using EmpAssetService.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpAssetService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }        

        public DbSet<EmpAsset> EmpAsset { get; set; }
    }
}
