﻿// <auto-generated />
using System;
using BlazorDate.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorDate.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230322151258_gender")]
    partial class gender
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorDate.Shared.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Address");
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.Availability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserSettingId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserSettingId");

                    b.ToTable("Availabilities");
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Så kallad cis-kvinna, som tänder främst på män.",
                            Name = "Female",
                            Url = "fem"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Identifirar sig främst som sitt biologiska kön och attraheras av sk mottsatta könet. Även så kallat Cis-man.",
                            Name = "Man",
                            Url = "men"
                        });
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ChatId")
                        .HasColumnType("int");

                    b.Property<DateTime>("MatchDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MatchLikedPersonPersonId")
                        .HasColumnType("int");

                    b.Property<int?>("MatchLikeePersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("MatchLikedPersonPersonId");

                    b.HasIndex("MatchLikeePersonId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ChatId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateRead")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<DateTime>("MessageSent")
                        .HasColumnType("datetime2");

                    b.Property<bool>("RecipientDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("SenderDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("SenderPersonId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("SenderPersonId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nick")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stats")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("PersonId");

                    b.HasIndex("GenderId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Vem är fullast?",
                            GenderId = 2,
                            LastActive = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Börje",
                            Nick = "Rattens riddare",
                            ProfileText = "",
                            Stats = 0,
                            Updated = new DateTime(2023, 3, 22, 16, 12, 58, 663, DateTimeKind.Local).AddTicks(7554)
                        },
                        new
                        {
                            PersonId = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lugn person med takt och ton, måttfull och balanserad.",
                            GenderId = 1,
                            LastActive = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cara",
                            Nick = "Carmen",
                            ProfileText = "",
                            Stats = 0,
                            Updated = new DateTime(2023, 3, 22, 16, 12, 58, 663, DateTimeKind.Local).AddTicks(7612)
                        },
                        new
                        {
                            PersonId = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Liten och dristig.",
                            GenderId = 1,
                            LastActive = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "My",
                            Nick = "Lilla My",
                            ProfileText = "",
                            Stats = 0,
                            Updated = new DateTime(2023, 3, 22, 16, 12, 58, 663, DateTimeKind.Local).AddTicks(7615)
                        },
                        new
                        {
                            PersonId = 4,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bär oftast hatt.",
                            GenderId = 2,
                            LastActive = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Mumriken",
                            Nick = "Snusmumriken",
                            ProfileText = "",
                            Stats = 0,
                            Updated = new DateTime(2023, 3, 22, 16, 12, 58, 663, DateTimeKind.Local).AddTicks(7618)
                        });
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.PersonPreference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsVisible")
                        .HasColumnType("bit");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<int?>("PreferenceId")
                        .HasColumnType("int");

                    b.Property<int?>("SeriousnessId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("PreferenceId");

                    b.HasIndex("SeriousnessId");

                    b.ToTable("PersonPreferences");
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.Picture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsExplecit")
                        .HasColumnType("bit");

                    b.Property<bool>("IsProfilePicture")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.Preference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Preferences");
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.Seriousness", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Seriousnesses");
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.UserSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AgeMax")
                        .HasColumnType("int");

                    b.Property<int>("AgeMin")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("UserSettings");
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.Address", b =>
                {
                    b.HasOne("BlazorDate.Shared.Models.User", null)
                        .WithOne("Address")
                        .HasForeignKey("BlazorDate.Shared.Models.Address", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.Availability", b =>
                {
                    b.HasOne("BlazorDate.Shared.Models.UserSetting", null)
                        .WithMany("Availabilities")
                        .HasForeignKey("UserSettingId");
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.Match", b =>
                {
                    b.HasOne("BlazorDate.Shared.Models.Chat", "Chat")
                        .WithMany()
                        .HasForeignKey("ChatId");

                    b.HasOne("BlazorDate.Shared.Models.Person", "MatchLikedPerson")
                        .WithMany()
                        .HasForeignKey("MatchLikedPersonPersonId");

                    b.HasOne("BlazorDate.Shared.Models.Person", "MatchLikee")
                        .WithMany()
                        .HasForeignKey("MatchLikeePersonId");

                    b.Navigation("Chat");

                    b.Navigation("MatchLikedPerson");

                    b.Navigation("MatchLikee");
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.Message", b =>
                {
                    b.HasOne("BlazorDate.Shared.Models.Chat", null)
                        .WithMany("Messages")
                        .HasForeignKey("ChatId");

                    b.HasOne("BlazorDate.Shared.Models.Person", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderPersonId");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.Person", b =>
                {
                    b.HasOne("BlazorDate.Shared.Models.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.PersonPreference", b =>
                {
                    b.HasOne("BlazorDate.Shared.Models.Person", "Person")
                        .WithMany("Preferences")
                        .HasForeignKey("PersonId");

                    b.HasOne("BlazorDate.Shared.Models.Preference", "Preference")
                        .WithMany()
                        .HasForeignKey("PreferenceId");

                    b.HasOne("BlazorDate.Shared.Models.Seriousness", "Seriousness")
                        .WithMany()
                        .HasForeignKey("SeriousnessId");

                    b.Navigation("Person");

                    b.Navigation("Preference");

                    b.Navigation("Seriousness");
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.Picture", b =>
                {
                    b.HasOne("BlazorDate.Shared.Models.Person", "Person")
                        .WithMany("Pictures")
                        .HasForeignKey("PersonId");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.UserSetting", b =>
                {
                    b.HasOne("BlazorDate.Shared.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.Chat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.Person", b =>
                {
                    b.Navigation("Pictures");

                    b.Navigation("Preferences");
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.User", b =>
                {
                    b.Navigation("Address");
                });

            modelBuilder.Entity("BlazorDate.Shared.Models.UserSetting", b =>
                {
                    b.Navigation("Availabilities");
                });
#pragma warning restore 612, 618
        }
    }
}
