using App.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.DataSeeders
{
	public static class AppCategorySeender
	{
        public static void SeenData(this EntityTypeBuilder<AppCategory> builder)
        {
			var now = new DateTime(year: 2021, month: 11, day: 10);
			var listCategory = new List<AppCategory>()
			{
				new AppCategory
				{
					Id = 1,
					Name = "DANH MỤC TEST",
					Description = "DANH MỤC TEST",
					CreatedBy = -1,
					UpdatedBy = -1,
					UpdatedDate = now,
					CreatedDate = now,
				},
				new AppCategory
				{
					Id = 2,
					Name = "DANH MỤC TEST",
					Description = "DANH MỤC TEST",
					CreatedBy = -1,
					UpdatedBy = -1,
					UpdatedDate = now,
					CreatedDate = now,
				},
				new AppCategory
				{
					Id = 3,
					Name = "DANH MỤC TEST",
					Description = "DANH MỤC TEST",
					CreatedBy = -1,
					UpdatedBy = -1,
					UpdatedDate = now,
					CreatedDate = now,
				},
			};
			builder.HasData(listCategory);
		}
    }
}
