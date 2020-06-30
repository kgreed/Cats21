using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DevExpress.ExpressApp.EF.DesignTime;
namespace Cats21.Module.BusinessObjects
{
    public class Cats21ContextInitializer : DbContextTypesInfoInitializerBase {
        protected override DbContext CreateDbContext() {
            DbContextInfo contextInfo = new DbContextInfo(typeof(Cats21DbContext), new DbProviderInfo(providerInvariantName: "System.Data.SqlClient", providerManifestToken: "2008"));
            return contextInfo.CreateInstance();
        }
    }
}