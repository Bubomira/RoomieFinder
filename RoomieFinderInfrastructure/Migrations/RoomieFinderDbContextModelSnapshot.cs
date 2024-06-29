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

                    b.ToTable("Answers", (string)null);
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
                            ConcurrencyStamp = "50f80976-c8c1-48cb-b69c-340dcd7ece61",
                            Email = "sofia_university_admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Sofia University",
                            HasChangedPassword = true,
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "SOFIA_UNIVERSITY_ADMIN@GMAIL.COM",
                            NormalizedUserName = "SOFIA UNIVERSITY ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAENbnaeVzwni5wDuL49hWTi7EIyOGWlKUz0qoFa0t655cWq3bo70gqcbgo2GUjOgNyQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "952be543-4542-4b26-be27-726cabb74460",
                            TwoFactorEnabled = false,
                            UserName = "Sofia University Admin"
                        },
                        new
                        {
                            Id = "169f682a-e6d0-4aca-8b74-d51dbcaa58ef",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8c564895-6dd6-429a-bf64-5326de9b9791",
                            Email = "medical_university_admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Medical University",
                            HasChangedPassword = true,
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "MEDICAL_UNIVERSITY_ADMIN@GMAIL.COM",
                            NormalizedUserName = "MEDICAL UNIVERSITY ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEDEJMB9b6dP2tINI78q0BQ9E1V9ATVSavuDEeIYTgROt3ZXd1scR1wzU4pCPuhJSbA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "16711141-21f0-4bc7-bfd8-af55ca14f0e4",
                            TwoFactorEnabled = false,
                            UserName = "Medical University Admin"
                        },
                        new
                        {
                            Id = "51d96dfa-943a-44a3-a39b-136844852055",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "395caaf1-6013-43d7-9b56-57b58814d603",
                            Email = "alisa_markova@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Alisa",
                            HasChangedPassword = true,
                            LastName = "Markova",
                            LockoutEnabled = false,
                            NormalizedEmail = "ALISA_MARKOVA@GMAIL.COM",
                            NormalizedUserName = "ALISE_MARIE",
                            PasswordHash = "AQAAAAIAAYagAAAAEGkpHVkXUjjXePdHhFGTN8S5vLlxm1GYP06/V56l3B9jLh1AKWhFJsrrKaI5tIOvdQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2c1e713f-9612-4b6f-a973-ca588b335ba8",
                            TwoFactorEnabled = false,
                            UserName = "Alise_Marie"
                        },
                        new
                        {
                            Id = "88273e30-0ad0-4095-b288-51f0d4f2eba0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b1b106b8-b608-42ef-9728-2876ef2e2d6f",
                            Email = "niki_g@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Nikolay",
                            HasChangedPassword = true,
                            LastName = "Georgiev",
                            LockoutEnabled = false,
                            NormalizedEmail = "NIKI_G@GMAIL.COM",
                            NormalizedUserName = "NIKK",
                            PasswordHash = "AQAAAAIAAYagAAAAEKO2e2NO+5hiefNraQrNgDt02dqCSECn5x9VgnIoe08G6fdyEyWtx5Y5vmKZNWY5+w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "16a9e27c-144e-4513-b270-a2369d12c772",
                            TwoFactorEnabled = false,
                            UserName = "Nikk"
                        },
                        new
                        {
                            Id = "47ca66e3-a4b0-43ca-916a-edf44842f9f7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c7f563b0-829c-48dd-b398-7c758145f9d7",
                            Email = "marina_nikolova.56@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Marina",
                            HasChangedPassword = true,
                            LastName = "Nikolova",
                            LockoutEnabled = false,
                            NormalizedEmail = "MARINA_NIKOLOVA@GMAIL.COM",
                            NormalizedUserName = "MARINA_",
                            PasswordHash = "AQAAAAIAAYagAAAAEJssi2tIGpgaDp4UiHnWAV9WR7YfwIPC7uR6gCcXj9r1NpXyA1AiSJe5BiLCl4coTQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "82428273-05e9-4710-834c-68cbb0818f08",
                            TwoFactorEnabled = false,
                            UserName = "Marina_"
                        },
                        new
                        {
                            Id = "cc3beb38-92d0-44b9-9470-d24ffe951850",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "521bac87-26b1-408d-b7ac-af846032cae6",
                            Email = "pepi_p@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Petar",
                            HasChangedPassword = true,
                            LastName = "Petrov",
                            LockoutEnabled = false,
                            NormalizedEmail = "PEPI_P@GMAIL.COM",
                            NormalizedUserName = "_PEPI",
                            PasswordHash = "AQAAAAIAAYagAAAAEAT31R9j0/9nBL2NPVHwThnRp+1kS01oGtUabtdkZ/yzDVkPGqgSt9nAvKSHPx2eLA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0b4e7c58-c4da-40d2-9952-0c648e1befa6",
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

                    b.ToTable("BlacklistedTokens", (string)null);
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

                    b.ToTable("Dormitories", null, t =>
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

                    b.ToTable("Questions", null, t =>
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

                    b.ToTable("Questionnaires", null, t =>
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

                    b.ToTable("Rooms", null, t =>
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

                    b.ToTable("Students", (string)null);

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

                    b.ToTable("StudentsAnswers", null, t =>
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
