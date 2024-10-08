﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.SeedDb.Seeders;


namespace RoomieFinderInfrastructure.SeedDb.Configurations
{
    internal class StudentQualityConfiguration : IEntityTypeConfiguration<StudentQualities>
    {
        public void Configure(EntityTypeBuilder<StudentQualities> builder)
        {
            //many-tomany relationship between student and asnwers
            builder
                .HasOne(sa => sa.Student)
                .WithMany(s => s.StudentQualities)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(sa => sa.StudentId);

            builder
                .HasOne(sa => sa.Quality)
                .WithMany(s => s.StudentsQualities)
                .HasForeignKey(sa => sa.QualityId);

            //configuring key for many-to-many student answer table
            builder.HasKey(sa => new { sa.QualityId, sa.StudentId });

            builder.HasData([
                StudentQualitySeeder.StudentQualityOne,
                StudentQualitySeeder.StudentQualityTwo,
                StudentQualitySeeder.StudentQualityThree,
                StudentQualitySeeder.StudentQualityFour,
                StudentQualitySeeder.StudentQualityFive,
                StudentQualitySeeder.StudentQualitySix,
                StudentQualitySeeder.StudentQualitySeven,
                StudentQualitySeeder.StudentQualityEigth,
                StudentQualitySeeder.StudentQualityNine,
                StudentQualitySeeder.StudentQualityTen,
                StudentQualitySeeder.StudentQualityEleven,
                StudentQualitySeeder.StudentQualityTwlevle
                ]);
        }
    }
}
