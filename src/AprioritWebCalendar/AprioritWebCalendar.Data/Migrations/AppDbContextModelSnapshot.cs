﻿// <auto-generated />
using AprioritWebCalendar.Data;
using AprioritWebCalendar.Infrastructure.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AprioritWebCalendar.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AprioritWebCalendar.Data.Models.ApplicationRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("AprioritWebCalendar.Data.Models.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool?>("IsTelegramNotificationEnabled");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<int?>("TelegramId");

                    b.Property<string>("TimeZone");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("AprioritWebCalendar.Data.Models.Calendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(7);

                    b.Property<string>("Description")
                        .HasMaxLength(256);

                    b.Property<bool>("IsDefault");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<int>("OwnerId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Calendars");
                });

            modelBuilder.Entity("AprioritWebCalendar.Data.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime?>("EndDate");

                    b.Property<TimeSpan?>("EndTime");

                    b.Property<bool>("IsAllDay");

                    b.Property<bool>("IsPrivate");

                    b.Property<double?>("Lattitude");

                    b.Property<string>("LocationDescription");

                    b.Property<double?>("Longitude");

                    b.Property<string>("Name");

                    b.Property<int>("OwnerId");

                    b.Property<int?>("RemindBefore");

                    b.Property<DateTime?>("StartDate");

                    b.Property<TimeSpan?>("StartTime");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("AprioritWebCalendar.Data.Models.EventCalendar", b =>
                {
                    b.Property<int>("EventId");

                    b.Property<int>("CalendarId");

                    b.Property<bool>("IsReadOnly");

                    b.HasKey("EventId", "CalendarId");

                    b.HasIndex("CalendarId");

                    b.ToTable("EventCalendars");
                });

            modelBuilder.Entity("AprioritWebCalendar.Data.Models.Invitation", b =>
                {
                    b.Property<int>("EventId");

                    b.Property<int>("UserId");

                    b.Property<int>("InvitatorId");

                    b.Property<bool>("IsReadOnly");

                    b.HasKey("EventId", "UserId", "InvitatorId");

                    b.HasAlternateKey("EventId", "InvitatorId", "UserId");

                    b.HasIndex("InvitatorId");

                    b.HasIndex("UserId");

                    b.ToTable("Invitations");
                });

            modelBuilder.Entity("AprioritWebCalendar.Data.Models.Period", b =>
                {
                    b.Property<int>("EventId");

                    b.Property<int?>("CycleDays");

                    b.Property<DateTime>("PeriodEnd");

                    b.Property<DateTime>("PeriodStart");

                    b.Property<int>("Type");

                    b.Property<int>("WholeDaysCount");

                    b.HasKey("EventId");

                    b.ToTable("EventPeriods");
                });

            modelBuilder.Entity("AprioritWebCalendar.Data.Models.TelegramCode", b =>
                {
                    b.Property<int>("TelegramId");

                    b.Property<string>("Code");

                    b.Property<DateTime>("CreatedDate");

                    b.HasKey("TelegramId", "Code");

                    b.ToTable("TelegramCodes");
                });

            modelBuilder.Entity("AprioritWebCalendar.Data.Models.UserCalendar", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("CalendarId");

                    b.Property<bool>("IsReadOnly");

                    b.Property<bool>("IsSubscribed");

                    b.HasKey("UserId", "CalendarId");

                    b.HasIndex("CalendarId");

                    b.ToTable("UserCalendars");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AprioritWebCalendar.Data.Models.Calendar", b =>
                {
                    b.HasOne("AprioritWebCalendar.Data.Models.ApplicationUser", "Owner")
                        .WithMany("OwnCalendars")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AprioritWebCalendar.Data.Models.Event", b =>
                {
                    b.HasOne("AprioritWebCalendar.Data.Models.ApplicationUser", "Owner")
                        .WithMany("OwnEvents")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AprioritWebCalendar.Data.Models.EventCalendar", b =>
                {
                    b.HasOne("AprioritWebCalendar.Data.Models.Calendar", "Calendar")
                        .WithMany("EventCalendars")
                        .HasForeignKey("CalendarId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AprioritWebCalendar.Data.Models.Event", "Event")
                        .WithMany("Calendars")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AprioritWebCalendar.Data.Models.Invitation", b =>
                {
                    b.HasOne("AprioritWebCalendar.Data.Models.Event", "Event")
                        .WithMany("Invitations")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AprioritWebCalendar.Data.Models.ApplicationUser", "Invitator")
                        .WithMany("OutcomingInvitations")
                        .HasForeignKey("InvitatorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AprioritWebCalendar.Data.Models.ApplicationUser", "User")
                        .WithMany("IncomingInvitations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AprioritWebCalendar.Data.Models.Period", b =>
                {
                    b.HasOne("AprioritWebCalendar.Data.Models.Event", "Event")
                        .WithOne("Period")
                        .HasForeignKey("AprioritWebCalendar.Data.Models.Period", "EventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AprioritWebCalendar.Data.Models.UserCalendar", b =>
                {
                    b.HasOne("AprioritWebCalendar.Data.Models.Calendar", "Calendar")
                        .WithMany("SharedUsers")
                        .HasForeignKey("CalendarId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AprioritWebCalendar.Data.Models.ApplicationUser", "User")
                        .WithMany("SharedCalendars")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("AprioritWebCalendar.Data.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("AprioritWebCalendar.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("AprioritWebCalendar.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("AprioritWebCalendar.Data.Models.ApplicationRole")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AprioritWebCalendar.Data.Models.ApplicationUser")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("AprioritWebCalendar.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
