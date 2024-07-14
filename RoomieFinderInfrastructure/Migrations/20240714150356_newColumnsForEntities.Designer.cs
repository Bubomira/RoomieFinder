﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoomieFinderInfrastructure.Data;

#nullable disable

namespace RoomieFinderInfrastructure.Migrations
{
    [DbContext(typeof(RoomieFinderDbContext))]
    [Migration("20240714150356_newColumnsForEntities")]
    partial class newColumnsForEntities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            ConcurrencyStamp = "3976e326-325e-4351-9fe1-f691fa0c4f9a",
                            Email = "sofia_university_admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Sofia University",
                            HasChangedPassword = true,
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "SOFIA_UNIVERSITY_ADMIN@GMAIL.COM",
                            NormalizedUserName = "SOFIA UNIVERSITY ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEIDVb0UcOvHaZ9zvxd9jv67XDDhMm1lbPh7LPLEIgZnSppeSQzGczalgXWU9k8DOQQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e1d9d492-06db-4384-b471-cd004f3d19ef",
                            TwoFactorEnabled = false,
                            UserName = "Sofia University Admin"
                        },
                        new
                        {
                            Id = "169f682a-e6d0-4aca-8b74-d51dbcaa58ef",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1686a9ff-f3a8-4133-b284-1852dba3f11a",
                            Email = "medical_university_admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Medical University",
                            HasChangedPassword = true,
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "MEDICAL_UNIVERSITY_ADMIN@GMAIL.COM",
                            NormalizedUserName = "MEDICAL UNIVERSITY ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAECbasymwVYWsQ4Yz2D+pA10Vk1q98xv3bNf1cBqls0Q/YlotFbZMQVb9dPrFkPRdyg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4fe7ce16-93b7-4c6d-82bd-aabf637c2cd0",
                            TwoFactorEnabled = false,
                            UserName = "Medical University Admin"
                        },
                        new
                        {
                            Id = "51d96dfa-943a-44a3-a39b-136844852055",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6af93970-94b6-4836-bf78-c3293f655097",
                            Email = "alisa_markova@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Alisa",
                            HasChangedPassword = true,
                            LastName = "Markova",
                            LockoutEnabled = false,
                            NormalizedEmail = "ALISA_MARKOVA@GMAIL.COM",
                            NormalizedUserName = "ALISE_MARIE",
                            PasswordHash = "AQAAAAIAAYagAAAAEGAsT5w+Ci7jkjFQoH7qrt6JyiipvL7sN8uyOQjETW1tv+u7chnZLpGjjW4G9eQU3g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f1914775-0cd8-4be5-8e4d-4be8bfa7097a",
                            TwoFactorEnabled = false,
                            UserName = "Alise_Marie"
                        },
                        new
                        {
                            Id = "88273e30-0ad0-4095-b288-51f0d4f2eba0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dfb6b1c4-77e6-4739-8984-3f169b5df412",
                            Email = "niki_g@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Nikolay",
                            HasChangedPassword = true,
                            LastName = "Georgiev",
                            LockoutEnabled = false,
                            NormalizedEmail = "NIKI_G@GMAIL.COM",
                            NormalizedUserName = "NIKK",
                            PasswordHash = "AQAAAAIAAYagAAAAEB/2grbkfLqct5pqQaE84fSmcey6TMjBqKbFg+ttvK1Ifec9hSXApKkneMbbLE73XQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "67299d51-8943-448e-b61f-db05089607d3",
                            TwoFactorEnabled = false,
                            UserName = "Nikk"
                        },
                        new
                        {
                            Id = "47ca66e3-a4b0-43ca-916a-edf44842f9f7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5c7d9a50-097c-4931-95c2-48d499c2b5ba",
                            Email = "marina_nikolova.56@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Marina",
                            HasChangedPassword = true,
                            LastName = "Nikolova",
                            LockoutEnabled = false,
                            NormalizedEmail = "MARINA_NIKOLOVA@GMAIL.COM",
                            NormalizedUserName = "MARINA_",
                            PasswordHash = "AQAAAAIAAYagAAAAEMRm1kXVh1YWzAhg4f2NEQV3yIyCxyV90ccupphWBmdRjQIjmTp03nSa62242sKa1Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "78afc755-4fff-435e-b95f-a7ca7c1fa20b",
                            TwoFactorEnabled = false,
                            UserName = "Marina_"
                        },
                        new
                        {
                            Id = "cc3beb38-92d0-44b9-9470-d24ffe951850",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "402c1cfc-be45-4e86-a4fa-ddc8913f097d",
                            Email = "pepi_p@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Petar",
                            HasChangedPassword = true,
                            LastName = "Petrov",
                            LockoutEnabled = false,
                            NormalizedEmail = "PEPI_P@GMAIL.COM",
                            NormalizedUserName = "_PEPI",
                            PasswordHash = "AQAAAAIAAYagAAAAEADeg8QSNtS5r36N2hVhlouVBrdrib8ZmsofoxOv0I/GBaebBotuQ7yat5krTWYEag==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f3b4e255-f121-4b1b-a01d-b6bae46e94b4",
                            TwoFactorEnabled = false,
                            UserName = "_Pepi"
                        });
                });

            modelBuilder.Entity("RoomieFinderInfrastructure.Models.BlacklistedToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BlacklistedTokens");
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

                    b.Property<bool>("IsReadyForFilling")
                        .HasColumnType("bit")
                        .HasComment("Describes if a questionaire can be filled out by students");

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

                    b.Property<int>("RemainingCapacity")
                        .HasColumnType("int")
                        .HasComment("Shows the remaining empty spots for a room, set to 0 when the room is full");

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

                    b.Property<bool>("IsMale")
                        .HasColumnType("bit")
                        .HasComment("An indicator to the gender of a student");

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
                            IsMale = false,
                            YearAtUniversity = 1
                        },
                        new
                        {
                            StudentId = 2,
                            ApplicationUserId = "88273e30-0ad0-4095-b288-51f0d4f2eba0",
                            HasGraduated = false,
                            IsMale = true,
                            YearAtUniversity = 1
                        },
                        new
                        {
                            StudentId = 3,
                            ApplicationUserId = "47ca66e3-a4b0-43ca-916a-edf44842f9f7",
                            HasGraduated = false,
                            IsMale = false,
                            YearAtUniversity = 2
                        },
                        new
                        {
                            StudentId = 4,
                            ApplicationUserId = "cc3beb38-92d0-44b9-9470-d24ffe951850",
                            HasGraduated = false,
                            IsMale = true,
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
                        .WithMany("Answers")
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
                    b.Navigation("Answers");
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