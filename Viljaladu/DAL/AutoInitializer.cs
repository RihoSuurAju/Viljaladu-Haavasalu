using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Viljaladu.Models;

namespace Viljaladu.DAL
{
	public class AutoInitializer : DropCreateDatabaseIfModelChanges<AutoContext>
	{
		protected override void Seed(AutoContext context)
		{
			var autod = new List<Auto>
			{
				new Auto
				{
					autoNr = "123A33",
					sisenemisMass = 24.67,
					lahkumisMass = 0
				},
				new Auto
				{
					autoNr = "1E431",
					sisenemisMass = 38.2,
					lahkumisMass = 0
				},
				new Auto
				{
					autoNr = "AWU321",
					sisenemisMass = 45.3,
					lahkumisMass = 27
				},
			};

			autod.ForEach(b => context.Autod.Add(b));

			context.SaveChanges();
		}
	}
}