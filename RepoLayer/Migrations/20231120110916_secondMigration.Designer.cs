﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepoLayer;

#nullable disable

namespace RepoLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231120110916_secondMigration")]
    partial class secondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RepoLayer.CampaignEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Campaign_Short_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Campaign_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("End_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FormatId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("LoginId")
                        .HasColumnType("int");

                    b.Property<int>("Maximum_Attempts")
                        .HasColumnType("int");

                    b.Property<int>("Pass_Percentage")
                        .HasColumnType("int");

                    b.Property<DateTime>("Start_Date")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("FormatId");

                    b.HasIndex("LoginId");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("RepoLayer.QuestionDifficultyEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Difficulty_Level")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("LoginId")
                        .HasColumnType("int");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("LoginId");

                    b.ToTable("Question_Difficulty_Levels");
                });

            modelBuilder.Entity("RepoLayer.QuestionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("LastUpdated_At")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("LoginId")
                        .HasColumnType("int");

                    b.Property<string>("Question_Difficulty_Level")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Question_Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Status_Flag")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("TopicId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LoginId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("RepoLayer.SessionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("LoginId")
                        .HasColumnType("int");

                    b.Property<DateTime>("session_End_DateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("session_Start_DateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("token")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("LoginId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("RepoLayer.TestFormatEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("LoginId")
                        .HasColumnType("int");

                    b.Property<int>("Question_Distribution")
                        .HasColumnType("int");

                    b.Property<DateTime>("Test_Duration")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Test_Format")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Total_Questions")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LoginId");

                    b.ToTable("Test_Format");
                });

            modelBuilder.Entity("RepoLayer.TopicEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("LoginId")
                        .HasColumnType("int");

                    b.Property<string>("Topic_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("LoginId");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("RepoLayer.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone_Number")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Updated_At")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<ulong>("isActive")
                        .HasColumnType("bit")
                        .HasColumnName("isActive");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RepoLayer.CampaignEntity", b =>
                {
                    b.HasOne("RepoLayer.TestFormatEntity", "TestFormat")
                        .WithMany()
                        .HasForeignKey("FormatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RepoLayer.UserEntity", "LoginEntity")
                        .WithMany()
                        .HasForeignKey("LoginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoginEntity");

                    b.Navigation("TestFormat");
                });

            modelBuilder.Entity("RepoLayer.QuestionDifficultyEntity", b =>
                {
                    b.HasOne("RepoLayer.UserEntity", "LoginEntity")
                        .WithMany()
                        .HasForeignKey("LoginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoginEntity");
                });

            modelBuilder.Entity("RepoLayer.QuestionEntity", b =>
                {
                    b.HasOne("RepoLayer.TopicEntity", "Topic")
                        .WithMany("Questions")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RepoLayer.UserEntity", "LoginEntity")
                        .WithMany()
                        .HasForeignKey("LoginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoginEntity");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("RepoLayer.SessionEntity", b =>
                {
                    b.HasOne("RepoLayer.UserEntity", "LoginEntity")
                        .WithMany()
                        .HasForeignKey("LoginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoginEntity");
                });

            modelBuilder.Entity("RepoLayer.TestFormatEntity", b =>
                {
                    b.HasOne("RepoLayer.UserEntity", "LoginEntity")
                        .WithMany()
                        .HasForeignKey("LoginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoginEntity");
                });

            modelBuilder.Entity("RepoLayer.TopicEntity", b =>
                {
                    b.HasOne("RepoLayer.UserEntity", "LoginEntity")
                        .WithMany()
                        .HasForeignKey("LoginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoginEntity");
                });

            modelBuilder.Entity("RepoLayer.TopicEntity", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
