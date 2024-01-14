﻿// <auto-generated />
using System;
using App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Data.Migrations
{
    [DbContext(typeof(WebAppDbContext))]
    [Migration("20231201131202_seenderData-category")]
    partial class seenderDatacategory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("App.Data.Entities.AppCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("AppCategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = -1,
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "DANH MỤC TEST",
                            Name = "DANH MỤC TEST",
                            UpdatedBy = -1,
                            UpdatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = -1,
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "DANH MỤC TEST",
                            Name = "DANH MỤC TEST",
                            UpdatedBy = -1,
                            UpdatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = -1,
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "DANH MỤC TEST",
                            Name = "DANH MỤC TEST",
                            UpdatedBy = -1,
                            UpdatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("App.Data.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("AppRole");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Quản trị toàn bộ hệ thống",
                            Name = "Quản trị hệ thống",
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("App.Data.Entities.AppRolePermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppRoleId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<int>("MstPermissionId")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AppRoleId");

                    b.HasIndex("MstPermissionId");

                    b.ToTable("AppRolePermission");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1101,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1102,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1103,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1104,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1105,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1001,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1002,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1003,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1004,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1005,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1006,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1007,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1008,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 14,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1205,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("App.Data.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("AppRoleId")
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("BlockedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BlockedTo")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("FullName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PhoneNumber1")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("PhoneNumber2")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("AppRoleId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("AppUser");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Thành phố Hồ Chí Minh",
                            AppRoleId = 1,
                            CreatedBy = -1,
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin_test@gmail.com",
                            FullName = "Obama",
                            PasswordHash = "$2a$11$HZ.CieHz9YW4VUSSWCAu/OIeHBbtiMBo1GBu5l/uCIpmYAS70ibo6",
                            PhoneNumber1 = "0928666158",
                            PhoneNumber2 = "0928666156",
                            UpdatedBy = -1,
                            UpdatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("App.Data.Entities.MstPermission", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Table")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("MstPermission");

                    b.HasData(
                        new
                        {
                            Id = 1103,
                            Code = "CREATE",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Thêm quyền",
                            GroupName = "Quản lý phân quyền",
                            Table = "AppRole"
                        },
                        new
                        {
                            Id = 1105,
                            Code = "DELETE",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Xóa quyền",
                            GroupName = "Quản lý phân quyền",
                            Table = "AppRole"
                        },
                        new
                        {
                            Id = 1104,
                            Code = "UPDATE",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Sửa quyền",
                            GroupName = "Quản lý phân quyền",
                            Table = "AppRole"
                        },
                        new
                        {
                            Id = 1102,
                            Code = "VIEW_DETAIL",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Xem chi tiết quyền",
                            GroupName = "Quản lý phân quyền",
                            Table = "AppRole"
                        },
                        new
                        {
                            Id = 1101,
                            Code = "VIEW_LIST",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Xem danh sách quyền",
                            GroupName = "Quản lý phân quyền",
                            Table = "AppRole"
                        },
                        new
                        {
                            Id = 1006,
                            Code = "BLOCK",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Khóa người dùng",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        },
                        new
                        {
                            Id = 1003,
                            Code = "CREATE",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Thêm người dùng",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        },
                        new
                        {
                            Id = 1008,
                            Code = "DELETE",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Xóa người dùng",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        },
                        new
                        {
                            Id = 1007,
                            Code = "UNBLOCK",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Mở khóa người dùng",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        },
                        new
                        {
                            Id = 1004,
                            Code = "UPDATE",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Cập nhật người dùng",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        },
                        new
                        {
                            Id = 1005,
                            Code = "UPDATE_PWD",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Đổi mật khẩu",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        },
                        new
                        {
                            Id = 1002,
                            Code = "VIEW_DETAIL",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Xem chi tiết người dùng",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        },
                        new
                        {
                            Id = 1001,
                            Code = "VIEW_LIST",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Xem danh sách người dùng",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        },
                        new
                        {
                            Id = 1205,
                            Code = "MANAGER",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Quản lý file hệ thống",
                            GroupName = "Quản lý file",
                            Table = "FileManager"
                        });
                });

            modelBuilder.Entity("App.Data.Entities.AppRolePermission", b =>
                {
                    b.HasOne("App.Data.Entities.AppRole", "AppRole")
                        .WithMany("AppRolePermissions")
                        .HasForeignKey("AppRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Data.Entities.MstPermission", "MstPermission")
                        .WithMany("AppRolePermissions")
                        .HasForeignKey("MstPermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppRole");

                    b.Navigation("MstPermission");
                });

            modelBuilder.Entity("App.Data.Entities.AppUser", b =>
                {
                    b.HasOne("App.Data.Entities.AppRole", "AppRole")
                        .WithMany("AppUsers")
                        .HasForeignKey("AppRoleId");

                    b.Navigation("AppRole");
                });

            modelBuilder.Entity("App.Data.Entities.AppRole", b =>
                {
                    b.Navigation("AppRolePermissions");

                    b.Navigation("AppUsers");
                });

            modelBuilder.Entity("App.Data.Entities.MstPermission", b =>
                {
                    b.Navigation("AppRolePermissions");
                });
#pragma warning restore 612, 618
        }
    }
}
