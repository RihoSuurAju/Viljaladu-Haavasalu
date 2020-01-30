using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Viljaladu.Models;

namespace Viljaladu.DAL
{
	public class AutoContext : DbContext
	{
		public AutoContext() : base("Default Connection") { }

		public DbSet<Auto> Autod { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

			base.OnModelCreating(modelBuilder);
		}
	}
}