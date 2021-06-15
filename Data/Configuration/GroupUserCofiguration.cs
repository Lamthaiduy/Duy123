using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
	public class GroupUserConfiguration : IEntityTypeConfiguration<GroupUser>
	{
		public void Configure(EntityTypeBuilder<GroupUser> builder)
		{
			builder.ToTable("GroupUsers");
		}
	}
}