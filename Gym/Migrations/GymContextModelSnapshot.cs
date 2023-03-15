﻿// <auto-generated />
using System;
using Gym.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gym.Migrations
{
    [DbContext(typeof(GymContext))]
    partial class GymContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Gym.Models.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int?>("TypeOfClassId")
                        .HasColumnType("int");

                    b.HasKey("ClassId");

                    b.HasIndex("InstructorId");

                    b.HasIndex("LocationId");

                    b.HasIndex("TypeOfClassId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Gym.Models.ClassMember", b =>
                {
                    b.Property<int>("ClassMemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.HasKey("ClassMemberId");

                    b.HasIndex("ClassId");

                    b.HasIndex("MemberId");

                    b.ToTable("ClassMembers");
                });

            modelBuilder.Entity("Gym.Models.Instructor", b =>
                {
                    b.Property<int>("InstructorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("InstructorName")
                        .HasColumnType("longtext");

                    b.HasKey("InstructorId");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("Gym.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("LocationName")
                        .HasColumnType("longtext");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Gym.Models.LocationInstructor", b =>
                {
                    b.Property<int>("LocationInstructorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.HasKey("LocationInstructorId");

                    b.HasIndex("InstructorId");

                    b.HasIndex("LocationId");

                    b.ToTable("LocationInstructors");
                });

            modelBuilder.Entity("Gym.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("MemberName")
                        .HasColumnType("longtext");

                    b.HasKey("MemberId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("Gym.Models.TypeOfClass", b =>
                {
                    b.Property<int>("TypeOfClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("TypeOfClassName")
                        .HasColumnType("longtext");

                    b.HasKey("TypeOfClassId");

                    b.ToTable("ClassTypes");
                });

            modelBuilder.Entity("Gym.Models.Class", b =>
                {
                    b.HasOne("Gym.Models.Instructor", "Instructor")
                        .WithMany("Classes")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gym.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gym.Models.TypeOfClass", null)
                        .WithMany("Classes")
                        .HasForeignKey("TypeOfClassId");

                    b.Navigation("Instructor");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Gym.Models.ClassMember", b =>
                {
                    b.HasOne("Gym.Models.Class", "Class")
                        .WithMany("JoinEntities")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gym.Models.Member", "Member")
                        .WithMany("JoinEntities")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Gym.Models.LocationInstructor", b =>
                {
                    b.HasOne("Gym.Models.Instructor", "Instructor")
                        .WithMany("JoinEntities")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gym.Models.Location", "Location")
                        .WithMany("JoinEntities")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructor");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Gym.Models.Class", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("Gym.Models.Instructor", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("Gym.Models.Location", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("Gym.Models.Member", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("Gym.Models.TypeOfClass", b =>
                {
                    b.Navigation("Classes");
                });
#pragma warning restore 612, 618
        }
    }
}
