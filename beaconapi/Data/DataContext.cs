using Microsoft.EntityFrameworkCore;

namespace beaconapi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Device> Devices { get; set; }
        public DbSet<DeviceSignalLog> DeviceSignalLogs { get; set; }
    }
}
