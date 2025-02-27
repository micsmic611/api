﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WMSLite.Core.Api;

#nullable disable

namespace core.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240510080715_UsersTable")]
    partial class UsersTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WMSLite.Core.Api.src.Entities.ItemLocationAssignmentDbo", b =>
                {
                    b.Property<decimal>("InternalItemLocNum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(9,0)")
                        .HasColumnName("INTERNAL_ITEM_LOC_NUM");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("InternalItemLocNum"));

                    b.Property<string>("AllocationLoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("ALLOCATION_LOC");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("COMPANY");

                    b.Property<DateTime>("DateTimeStamp")
                        .HasColumnType("datetime")
                        .HasColumnName("DATE_TIME_STAMP");

                    b.Property<string>("Item")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("ITEM");

                    b.Property<string>("ProcessStamp")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("PROCESS_STAMP");

                    b.Property<string>("QuantityUm")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("QUANTITY_UM");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TENANT_ID");

                    b.Property<string>("UserDef1")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("USER_DEF1");

                    b.Property<string>("UserDef2")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("USER_DEF2");

                    b.Property<string>("UserDef3")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("USER_DEF3");

                    b.Property<string>("UserDef4")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("USER_DEF4");

                    b.Property<string>("UserDef5")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("USER_DEF5");

                    b.Property<string>("UserDef6")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("USER_DEF6");

                    b.Property<string>("UserDef7")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("USER_DEF7");

                    b.Property<string>("UserDef8")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("USER_DEF8");

                    b.Property<string>("UserStamp")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("USER_STAMP");

                    b.Property<string>("warehouse")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("warehouse");

                    b.HasKey("InternalItemLocNum");

                    b.ToTable("ITEM_LOCATION_ASSIGNMENT");
                });
#pragma warning restore 612, 618
        }
    }
}
