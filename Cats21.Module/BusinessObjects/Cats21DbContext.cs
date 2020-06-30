using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.ComponentModel;
using DevExpress.ExpressApp.EF.Updating;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.ExpressApp.Design;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;

namespace Cats21.Module.BusinessObjects {
    [TypesInfoInitializer(typeof(Cats21ContextInitializer))]
	public class Cats21DbContext : DbContext {
		public Cats21DbContext(String connectionString)
			: base(connectionString) {
		}
		public Cats21DbContext(DbConnection connection)
			: base(connection, false) {
		}
		public Cats21DbContext() {
		}
		public DbSet<Cat> Cats { get; set; }
		public DbSet<ModuleInfo> ModulesInfo { get; set; }
	    public DbSet<PermissionPolicyRole> Roles { get; set; }
		public DbSet<PermissionPolicyTypePermissionObject> TypePermissionObjects { get; set; }
		public DbSet<PermissionPolicyUser> Users { get; set; }
		public DbSet<ModelDifference> ModelDifferences { get; set; }
		public DbSet<ModelDifferenceAspect> ModelDifferenceAspects { get; set; }
	}
}