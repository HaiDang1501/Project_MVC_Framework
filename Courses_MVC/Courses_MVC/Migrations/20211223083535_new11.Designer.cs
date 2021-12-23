﻿// <auto-generated />
using System;
using Courses_MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Courses_MVC.Migrations
{
    [DbContext(typeof(CoursesContext))]
    [Migration("20211223083535_new11")]
    partial class new11
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Courses_MVC.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.Property<string>("address")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("birthday")
                        .HasColumnType("datetime");

                    b.Property<string>("gender")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("AppUser");
                });

            modelBuilder.Entity("Courses_MVC.Models.Comment", b =>
                {
                    b.Property<int>("courseId")
                        .HasColumnType("int");

                    b.Property<string>("userId")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("varchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<float>("evaluate")
                        .HasColumnType("float");

                    b.HasKey("courseId", "userId");

                    b.HasIndex("userId");

                    b.ToTable("comment");
                });

            modelBuilder.Entity("Courses_MVC.Models.Contact", b =>
                {
                    b.Property<int>("contactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AppUserId")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("HoTen")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("contactId");

                    b.HasIndex("AppUserId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("Courses_MVC.Models.Course", b =>
                {
                    b.Property<int>("courseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("courseName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("discountId")
                        .HasColumnType("int");

                    b.Property<string>("discription")
                        .IsRequired()
                        .HasColumnType("varchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("imgCourse")
                        .IsRequired()
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("originalPrice")
                        .HasColumnType("int");

                    b.Property<int>("price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("rating")
                        .HasColumnType("int");

                    b.Property<int>("topicId")
                        .HasColumnType("int");

                    b.Property<int>("totalStudent")
                        .HasColumnType("int");

                    b.Property<string>("totalTime")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("courseId");

                    b.HasIndex("discountId");

                    b.HasIndex("topicId");

                    b.ToTable("course");
                });

            modelBuilder.Entity("Courses_MVC.Models.Discount", b =>
                {
                    b.Property<int>("discountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("discription")
                        .IsRequired()
                        .HasColumnType("varchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<float>("sale")
                        .HasColumnType("float");

                    b.Property<DateTime>("time")
                        .HasColumnType("datetime");

                    b.HasKey("discountId");

                    b.ToTable("discount");
                });

            modelBuilder.Entity("Courses_MVC.Models.Exercise", b =>
                {
                    b.Property<int>("exerciseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("varchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<DateTime>("deadline")
                        .HasColumnType("date");

                    b.Property<string>("exerciseName")
                        .IsRequired()
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("input")
                        .IsRequired()
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("lessonId")
                        .HasColumnType("int");

                    b.Property<string>("output")
                        .IsRequired()
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("userId")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("exerciseId");

                    b.HasIndex("lessonId");

                    b.HasIndex("userId");

                    b.ToTable("exercise");
                });

            modelBuilder.Entity("Courses_MVC.Models.ExerciseInUser", b =>
                {
                    b.Property<string>("userId")
                        .HasColumnType("varchar(767)");

                    b.Property<int>("exerciseId")
                        .HasColumnType("int");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("scores")
                        .HasColumnType("float");

                    b.Property<DateTime>("submit")
                        .HasColumnType("datetime");

                    b.HasKey("userId", "exerciseId");

                    b.HasIndex("exerciseId");

                    b.ToTable("exerciseInUser");
                });

            modelBuilder.Entity("Courses_MVC.Models.Lesson", b =>
                {
                    b.Property<int>("lessonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("varchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<int>("courseId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("lessonId");

                    b.HasIndex("courseId");

                    b.ToTable("lesson");
                });

            modelBuilder.Entity("Courses_MVC.Models.Receipt", b =>
                {
                    b.Property<int>("receiptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("registerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("timeReceipt")
                        .HasColumnType("datetime");

                    b.Property<float>("totalPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0f);

                    b.HasKey("receiptId");

                    b.HasIndex("registerId");

                    b.ToTable("receipt");
                });

            modelBuilder.Entity("Courses_MVC.Models.Register", b =>
                {
                    b.Property<int>("registerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("courseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("timeReg")
                        .HasColumnType("datetime");

                    b.Property<string>("userId")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("registerId");

                    b.HasIndex("courseId");

                    b.HasIndex("userId");

                    b.ToTable("register");
                });

            modelBuilder.Entity("Courses_MVC.Models.Topic", b =>
                {
                    b.Property<int>("topicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("topicName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("topicId");

                    b.ToTable("topic");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<string>", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AppRole");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole<string>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasMaxLength(100);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasMaxLength(100);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogin");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("AppUserRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("AppUserToken");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole<string>");

                    b.HasDiscriminator().HasValue("IdentityRole");
                });

            modelBuilder.Entity("Courses_MVC.Models.Comment", b =>
                {
                    b.HasOne("Courses_MVC.Models.Course", "Course")
                        .WithMany("Comments")
                        .HasForeignKey("courseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Courses_MVC.Models.AppUser", "AppUser")
                        .WithMany("Comments")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Courses_MVC.Models.Contact", b =>
                {
                    b.HasOne("Courses_MVC.Models.AppUser", "AppUser")
                        .WithMany("Contacts")
                        .HasForeignKey("AppUserId");
                });

            modelBuilder.Entity("Courses_MVC.Models.Course", b =>
                {
                    b.HasOne("Courses_MVC.Models.Discount", "Discount")
                        .WithMany("Courses")
                        .HasForeignKey("discountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Courses_MVC.Models.Topic", "Topic")
                        .WithMany("Course")
                        .HasForeignKey("topicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Courses_MVC.Models.Exercise", b =>
                {
                    b.HasOne("Courses_MVC.Models.Lesson", "Lesson")
                        .WithMany("Exercises")
                        .HasForeignKey("lessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Courses_MVC.Models.AppUser", "AppUser")
                        .WithMany("Exercises")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Courses_MVC.Models.ExerciseInUser", b =>
                {
                    b.HasOne("Courses_MVC.Models.Exercise", "Exercise")
                        .WithMany("ExerciseInUsers")
                        .HasForeignKey("exerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Courses_MVC.Models.AppUser", "AppUser")
                        .WithMany("ExerciseInUsers")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Courses_MVC.Models.Lesson", b =>
                {
                    b.HasOne("Courses_MVC.Models.Course", "Course")
                        .WithMany("Lessons")
                        .HasForeignKey("courseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Courses_MVC.Models.Receipt", b =>
                {
                    b.HasOne("Courses_MVC.Models.Register", "Register")
                        .WithMany("Receipts")
                        .HasForeignKey("registerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Courses_MVC.Models.Register", b =>
                {
                    b.HasOne("Courses_MVC.Models.Course", "Course")
                        .WithMany("Registers")
                        .HasForeignKey("courseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Courses_MVC.Models.AppUser", "AppUser")
                        .WithMany("Registers")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}