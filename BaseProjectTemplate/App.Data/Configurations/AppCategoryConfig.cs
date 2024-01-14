using App.Data.Entities;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Configurations
{
	public class AppCategoryConfig : IEntityTypeConfiguration<AppCategory>
	{
		public void Configure(EntityTypeBuilder<AppCategory> builder)
		{
			builder.ToTable(DB.AppCategory.TABLE_NAME);

			builder.HasKey(t => t.Id);

			builder.Property(c => c.Name)
					.HasMaxLength(DB.AppCategory.USERNAME_LENGTH);

			builder.Property(c => c.Description)
					.HasMaxLength(DB.AppCategory.DESCRIPTION_LENGTH);
		}
	}
}
