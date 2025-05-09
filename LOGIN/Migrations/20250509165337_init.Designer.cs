﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LOGIN.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250509165337_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Security")
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("LOGIN.Entities.BlocksEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("blocks", "calendar");
                });

            modelBuilder.Entity("LOGIN.Entities.CommunicateEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(8000)
                        .HasColumnType("varchar(8000)")
                        .HasColumnName("content");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("tittle");

                    b.Property<string>("Type_Statement")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("type_statement");

                    b.Property<string>("User_Id")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("User_Id");

                    b.ToTable("communicate", "post");
                });

            modelBuilder.Entity("LOGIN.Entities.DistrictsPointsEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("latitude");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("longitude");

                    b.Property<Guid>("NeighborhoodsColoniesId")
                        .HasColumnType("char(36)")
                        .HasColumnName("neighborhoodsColonies_id");

                    b.HasKey("Id");

                    b.HasIndex("NeighborhoodsColoniesId");

                    b.ToTable("districtsPoints", "calendar");
                });

            modelBuilder.Entity("LOGIN.Entities.LinesEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("name");

                    b.Property<Guid>("NeighborhoodsColoniesId")
                        .HasColumnType("char(36)")
                        .HasColumnName("neighborhoodsColonies_id");

                    b.HasKey("Id");

                    b.HasIndex("NeighborhoodsColoniesId");

                    b.ToTable("lines", "calendar");
                });

            modelBuilder.Entity("LOGIN.Entities.NeighborhoodsColoniesEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<Guid>("BlockId")
                        .HasColumnType("char(36)")
                        .HasColumnName("block_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("BlockId");

                    b.ToTable("neighborhoodsColonies", "calendar");
                });

            modelBuilder.Entity("LOGIN.Entities.RegistrationWaterEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date");

                    b.Property<string>("Observations")
                        .HasColumnType("longtext")
                        .HasColumnName("observations");

                    b.HasKey("Id");

                    b.ToTable("registrationWater", "calendar");
                });

            modelBuilder.Entity("LOGIN.Entities.RegistrationWaterNeighborhoodsColoniesEntity", b =>
                {
                    b.Property<Guid>("RegistrationWaterId")
                        .HasColumnType("char(36)")
                        .HasColumnName("registrationWaterId");

                    b.Property<Guid>("NeighborhoodColoniesId")
                        .HasColumnType("char(36)")
                        .HasColumnName("neighborhoodColoniesId");

                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.HasKey("RegistrationWaterId", "NeighborhoodColoniesId");

                    b.HasIndex("NeighborhoodColoniesId");

                    b.ToTable("registrationWaterNeighborhoodsColonies", "calendar");
                });

            modelBuilder.Entity("LOGIN.Entities.ReportEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<string>("Cellphone")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("cellphone");

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("dni");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date");

                    b.Property<string>("Direction")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("direction");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("key");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("observation");

                    b.Property<string>("PublicIds")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("publicids");

                    b.Property<string>("Report")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("report");

                    b.Property<Guid>("StateId")
                        .HasColumnType("char(36)")
                        .HasColumnName("state_id");

                    b.Property<string>("Urls")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("urls");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("report", "reports");
                });

            modelBuilder.Entity("LOGIN.Entities.StateEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("state", "reports");
                });

            modelBuilder.Entity("LOGIN.Entities.UserEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordResetToken")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("PasswordResetTokenExpires")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("RefreshToken")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("refresh_token");

                    b.Property<DateTime>("RefreshTokenDate")
                        .HasColumnType("datetime")
                        .HasColumnName("refresh-token-date");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("users", "Security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("roles", "Security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("roles_claims", "Security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("users_claims", "Security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("users_logins", "Security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("users_roles", "Security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("users_tokens", "Security");
                });

            modelBuilder.Entity("LOGIN.Entities.CommunicateEntity", b =>
                {
                    b.HasOne("LOGIN.Entities.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("User_Id");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LOGIN.Entities.DistrictsPointsEntity", b =>
                {
                    b.HasOne("LOGIN.Entities.NeighborhoodsColoniesEntity", "NeighborhoodsColonies")
                        .WithMany()
                        .HasForeignKey("NeighborhoodsColoniesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NeighborhoodsColonies");
                });

            modelBuilder.Entity("LOGIN.Entities.LinesEntity", b =>
                {
                    b.HasOne("LOGIN.Entities.NeighborhoodsColoniesEntity", "NeighborhoodsColonies")
                        .WithMany()
                        .HasForeignKey("NeighborhoodsColoniesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NeighborhoodsColonies");
                });

            modelBuilder.Entity("LOGIN.Entities.NeighborhoodsColoniesEntity", b =>
                {
                    b.HasOne("LOGIN.Entities.BlocksEntity", "Block")
                        .WithMany()
                        .HasForeignKey("BlockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Block");
                });

            modelBuilder.Entity("LOGIN.Entities.RegistrationWaterNeighborhoodsColoniesEntity", b =>
                {
                    b.HasOne("LOGIN.Entities.NeighborhoodsColoniesEntity", "NeighborhoodsColonies")
                        .WithMany()
                        .HasForeignKey("NeighborhoodColoniesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LOGIN.Entities.RegistrationWaterEntity", "RegistrationWater")
                        .WithMany("RegistrationWaterNeighborhoodsColonies")
                        .HasForeignKey("RegistrationWaterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NeighborhoodsColonies");

                    b.Navigation("RegistrationWater");
                });

            modelBuilder.Entity("LOGIN.Entities.ReportEntity", b =>
                {
                    b.HasOne("LOGIN.Entities.StateEntity", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("LOGIN.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LOGIN.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LOGIN.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("LOGIN.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LOGIN.Entities.RegistrationWaterEntity", b =>
                {
                    b.Navigation("RegistrationWaterNeighborhoodsColonies");
                });
#pragma warning restore 612, 618
        }
    }
}
