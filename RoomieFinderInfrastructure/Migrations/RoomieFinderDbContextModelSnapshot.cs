﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoomieFinderInfrastructure.Data;

#nullable disable

namespace RoomieFinderInfrastructure.Migrations
{
    [DbContext(typeof(RoomieFinderDbContext))]
    partial class RoomieFinderDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1d9ae291-1067-4ec5-9f2b-ad0ea4bd8b0e",
                            Name = "GreatAdmin",
                            NormalizedName = "GREATADMIN"
                        },
                        new
                        {
                            Id = "7ed277c0-8163-466a-ad9b-942646c198c7",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "77cc9efa-570e-464c-a3c3-805a1cf94b30",
                            RoleId = "1d9ae291-1067-4ec5-9f2b-ad0ea4bd8b0e"
                        },
                        new
                        {
                            UserId = "169f682a-e6d0-4aca-8b74-d51dbcaa58ef",
                            RoleId = "1d9ae291-1067-4ec5-9f2b-ad0ea4bd8b0e"
                        },
                        new
                        {
                            UserId = "51d96dfa-943a-44a3-a39b-136844852055",
                            RoleId = "7ed277c0-8163-466a-ad9b-942646c198c7"
                        },
                        new
                        {
                            UserId = "88273e30-0ad0-4095-b288-51f0d4f2eba0",
                            RoleId = "7ed277c0-8163-466a-ad9b-942646c198c7"
                        },
                        new
                        {
                            UserId = "47ca66e3-a4b0-43ca-916a-edf44842f9f7",
                            RoleId = "7ed277c0-8163-466a-ad9b-942646c198c7"
                        },
                        new
                        {
                            UserId = "cc3beb38-92d0-44b9-9470-d24ffe951850",
                            RoleId = "7ed277c0-8163-466a-ad9b-942646c198c7"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("RoomieFinderInfrastructure.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("The unique identifyer for an answer");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("The content of the answer");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("RoomieFinderInfrastructure.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("The first name of each user");

                    b.Property<bool>("HasChangedPassword")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasComment("The last name of a user");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", null, t =>
                        {
                            t.HasComment("The user of the application");
                        });

                    b.HasData(
                        new
                        {
                            Id = "77cc9efa-570e-464c-a3c3-805a1cf94b30",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "18cc7c1c-b016-4158-ad87-0325143de47d",
                            Email = "sofia_university_admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Sofia University",
                            HasChangedPassword = true,
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "SOFIA_UNIVERSITY_ADMIN@GMAIL.COM",
                            NormalizedUserName = "SOFIA UNIVERSITY ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEKV2B5rzsLLUZo7DEapUrvTyk6u/IpIPAwcWZ1hu/BypJTIiomWUvIJZdmD+90OsDw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8d479d74-ca6b-4aad-80be-b5b21276a13a",
                            TwoFactorEnabled = false,
                            UserName = "Sofia University Admin"
                        },
                        new
                        {
                            Id = "169f682a-e6d0-4aca-8b74-d51dbcaa58ef",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "814eea77-56ad-4b92-a7f0-0775db69e2f8",
                            Email = "medical_university_admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Medical University",
                            HasChangedPassword = true,
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "MEDICAL_UNIVERSITY_ADMIN@GMAIL.COM",
                            NormalizedUserName = "MEDICAL UNIVERSITY ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEIhC/iOi53bk7V79OyyDYIiSkjUfnI8pHI8Ds7S5GeX0a3+lZO7wAhdQtgsUBqx69Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "afa4ee30-a98c-4cc7-9c5c-31cf4e3bdc90",
                            TwoFactorEnabled = false,
                            UserName = "Medical University Admin"
                        },
                        new
                        {
                            Id = "51d96dfa-943a-44a3-a39b-136844852055",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4e436310-e71a-4cc2-8b28-43d14b6a327d",
                            Email = "alisa_markova@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Alisa",
                            HasChangedPassword = true,
                            LastName = "Markova",
                            LockoutEnabled = false,
                            NormalizedEmail = "ALISA_MARKOVA@GMAIL.COM",
                            NormalizedUserName = "ALISE_MARIE",
                            PasswordHash = "AQAAAAIAAYagAAAAEA17DFEQQoMX+auHGwthnz8N9xxqkk7vXd3h/2JY1lD37IBYjf5cZqwA+BMr4r0vRw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a29a1bc3-e92e-40a9-b201-37f6ed1df101",
                            TwoFactorEnabled = false,
                            UserName = "Alise_Marie"
                        },
                        new
                        {
                            Id = "88273e30-0ad0-4095-b288-51f0d4f2eba0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3e32f90d-5c19-4eca-ac48-05d7ea8a6a6e",
                            Email = "niki_g@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Nikolay",
                            HasChangedPassword = true,
                            LastName = "Georgiev",
                            LockoutEnabled = false,
                            NormalizedEmail = "NIKI_G@GMAIL.COM",
                            NormalizedUserName = "NIKK",
                            PasswordHash = "AQAAAAIAAYagAAAAEKs3YMCpvV5yczdggkO8O2joA8EiA5TU+Rw0XL+FlpD1pfKBa5XccrsRaI7dXsixmg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ba6b4948-b0cd-41c5-91e7-2df5157b8487",
                            TwoFactorEnabled = false,
                            UserName = "Nikk"
                        },
                        new
                        {
                            Id = "47ca66e3-a4b0-43ca-916a-edf44842f9f7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7f30a499-3609-40fe-ad52-e920c1d1fa7b",
                            Email = "marina_nikolova.56@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Marina",
                            HasChangedPassword = true,
                            LastName = "Nikolova",
                            LockoutEnabled = false,
                            NormalizedEmail = "MARINA_NIKOLOVA@GMAIL.COM",
                            NormalizedUserName = "MARINA_",
                            PasswordHash = "AQAAAAIAAYagAAAAED8lvhSnRQJaa2yHDINI4vxqSvD/LeXsyhvXl7rGuCkVRPDS85PUpp3ofyCe9KrBNQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "77309649-7f09-4f87-a6fb-407de2411167",
                            TwoFactorEnabled = false,
                            UserName = "Marina_"
                        },
                        new
                        {
                            Id = "cc3beb38-92d0-44b9-9470-d24ffe951850",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8a609f68-3cec-4f0c-9880-48e15a888827",
                            Email = "pepi_p@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Petar",
                            HasChangedPassword = true,
                            LastName = "Petrov",
                            LockoutEnabled = false,
                            NormalizedEmail = "PEPI_P@GMAIL.COM",
                            NormalizedUserName = "_PEPI",
                            PasswordHash = "AQAAAAIAAYagAAAAEO0iJNaMe3mioEngtiqVp25WWbNWDLeDd7fWJBkD2UFFf1zoxhaLE6vK7QeqqQMrVA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d3632ed1-3ebf-4325-b9d7-56e86f71de3a",
                            TwoFactorEnabled = false,
                            UserName = "_Pepi"
                        });
                });

            modelBuilder.Entity("RoomieFinderInfrastructure.Models.Dormitory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Unique identifyer of each dormitory");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("The name of the dormitory");

                    b.HasKey("Id");

                    b.ToTable("Dormitories", t =>
                        {
                            t.HasComment("Dormitory is the place where students live");
                        });
                });

            modelBuilder.Entity("RoomieFinderInfrastructure.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("The unique identifyer of a question");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasComment("The title of the question");

                    b.Property<bool>("IsSingleAnswer")
                        .HasColumnType("bit")
                        .HasComment("The type of a question, can be radio or checkbox");

                    b.Property<int>("QuestionnaireId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionnaireId");

                    b.ToTable("Questions", t =>
                        {
                            t.HasComment("Question from the test");
                        });
                });

            modelBuilder.Entity("RoomieFinderInfrastructure.Models.Questionnaire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("The unique identifyer of each questionnaire");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasComment("Description of the questionnaire, gives aditional info");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("The title of a questionaire");

                    b.HasKey("Id");

                    b.ToTable("Questionnaires", t =>
                        {
                            t.HasComment("The test which holds the roomate questions students need to fill out");
                        });
                });

            modelBuilder.Entity("RoomieFinderInfrastructure.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("The unique identifyer of a room in the database");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DormitoryId")
                        .HasColumnType("int");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int")
                        .HasComment("The room number is its identifyer in the dormitory");

                    b.Property<int>("RoomType")
                        .HasColumnType("int")
                        .HasComment("Room type, can be single, duplex, apartament");

                    b.HasKey("Id");

                    b.HasIndex("DormitoryId");

                    b.ToTable("Rooms", t =>
                        {
                            t.HasComment("Room in dormitory");
                        });
                });

            modelBuilder.Entity("RoomieFinderInfrastructure.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("The unique identifyer for each student");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("HasGraduated")
                        .HasColumnType("bit")
                        .HasComment("Shows if a student has graduated, graduated students cannot use the application");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("YearAtUniversity")
                        .HasColumnType("int")
                        .HasComment("Year of attending the university");

                    b.HasKey("StudentId");

                    b.HasIndex("ApplicationUserId")
                        .IsUnique();

                    b.HasIndex("RoomId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            ApplicationUserId = "51d96dfa-943a-44a3-a39b-136844852055",
                            HasGraduated = false,
                            YearAtUniversity = 1
                        },
                        new
                        {
                            StudentId = 2,
                            ApplicationUserId = "88273e30-0ad0-4095-b288-51f0d4f2eba0",
                            HasGraduated = false,
                            YearAtUniversity = 1
                        },
                        new
                        {
                            StudentId = 3,
                            ApplicationUserId = "47ca66e3-a4b0-43ca-916a-edf44842f9f7",
                            HasGraduated = false,
                            YearAtUniversity = 2
                        },
                        new
                        {
                            StudentId = 4,
                            ApplicationUserId = "cc3beb38-92d0-44b9-9470-d24ffe951850",
                            HasGraduated = false,
                            YearAtUniversity = 3
                        });
                });

            modelBuilder.Entity("RoomieFinderInfrastructure.Models.StudentAnswer", b =>
                {
                    b.Property<int>("AnswerId")
                        .HasColumnType("int")
                        .HasComment("The answer id picked by the student, part of composite key");

                    b.Property<int>("StudentId")
                        .HasColumnType("int")
                        .HasComment("The student id who has picked the answer, part of composite key");

                    b.HasKey("AnswerId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentsAnswers", t =>
                        {
                            t.HasComment("All of the student answers to the questionnaire");
                        });
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
                    b.HasOne("RoomieFinderInfrastructure.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("RoomieFinderInfrastructure.Models.ApplicationUser", null)
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

                    b.HasOne("RoomieFinderInfrastructure.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("RoomieFinderInfrastructure.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RoomieFinderInfrastructure.Models.Answer", b =>
                {
                    b.HasOne("RoomieFinderInfrastructure.Models.Question", "Question")
                        .WithMany("Answer")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("RoomieFinderInfrastructure.Models.Question", b =>
                {
                    b.HasOne("RoomieFinderInfrastructure.Models.Questionnaire", "Questionnaire")
                        .WithMany("Questions")
                        .HasForeignKey("QuestionnaireId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Questionnaire");
                });

            modelBuilder.Entity("RoomieFinderInfrastructure.Models.Room", b =>
                {
                    b.HasOne("RoomieFinderInfrastructure.Models.Dormitory", "Dormitory")
                        .WithMany("Rooms")
                        .HasForeignKey("DormitoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dormitory");
                });

            modelBuilder.Entity("RoomieFinderInfrastructure.Models.Student", b =>
                {
                    b.HasOne("RoomieFinderInfrastructure.Models.ApplicationUser", "ApplicationUser")
                        .WithOne("Student")
                        .HasForeignKey("RoomieFinderInfrastructure.Models.Student", "ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RoomieFinderInfrastructure.Models.Room", "Room")
                        .WithMany("Students")
                        .HasForeignKey("RoomId");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("RoomieFinderInfrastructure.Models.StudentAnswer", b =>
                {
                    b.HasOne("RoomieFinderInfrastructure.Models.Answer", "Answer")
                        .WithMany("StudentAnswers")
                        .HasForeignKey("AnswerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RoomieFinderInfrastructure.Models.Student", "Student")
                        .WithMany("StudentAnswers")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Answer");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("RoomieFinderInfrastructure.Models.Answer", b =>
                {
                    b.Navigation("StudentAnswers");
                });

            modelBuilder.Entity("RoomieFinderInfrastructure.Models.ApplicationUser", b =>
                {
                    b.Navigation("Student");
                });

            modelBuilder.Entity("RoomieFinderInfrastructure.Models.Dormitory", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("RoomieFinderInfrastructure.Models.Question", b =>
                {
                    b.Navigation("Answer");
                });

            modelBuilder.Entity("RoomieFinderInfrastructure.Models.Questionnaire", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("RoomieFinderInfrastructure.Models.Room", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("RoomieFinderInfrastructure.Models.Student", b =>
                {
                    b.Navigation("StudentAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}
