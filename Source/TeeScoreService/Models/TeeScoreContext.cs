using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Microsoft.Azure.Mobile.Server;
using Microsoft.Azure.Mobile.Server.Tables;
using TeeScoreService.DataObjects;

namespace TeeScoreService.Models
{
    public class TeeScoreContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to alter your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        private const string ConnectionStringName = "Name=MS_TableConnectionString";

        public TeeScoreContext() : base(ConnectionStringName)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<VenueFacilities> VenueFacilities { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<GamePlayer> GamePlayers { get; set; }
        public DbSet<AvailabilityPeriod> AvailabilityPeriods { get; set; }
        public DbSet<Availability> Availabilities { get; set; }
        public DbSet<VenueAvailabilityPeriod> VenueAvailabilityPeriods { get; set; }
        public DbSet<Tee> Tees { get; set; }
        public DbSet<Score> Scores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add(
                new AttributeToColumnAnnotationConvention<TableColumnAttribute, string>(
                    "ServiceTableColumn", (property, attributes) => attributes.Single().ColumnType.ToString()));
        }
    }

}
