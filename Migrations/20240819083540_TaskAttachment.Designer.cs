﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskManagementSystem.Data;

#nullable disable

namespace TaskManagementSystem.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20240819083540_TaskAttachment")]
    partial class TaskAttachment
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Attachment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("MaxLength")
                        .HasColumnType("int");

                    b.Property<int>("MinLength")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhysicalPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Size")
                        .HasColumnType("bigint");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Attachments");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"));

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("MaxLength")
                        .HasColumnType("int");

                    b.Property<int>("MinLength")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Project", b =>
                {
                    b.Property<int>("projectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("projectId"));

                    b.Property<int>("attachmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("expectedDateToStart")
                        .HasColumnType("datetime2");

                    b.Property<bool>("flag")
                        .HasColumnType("bit");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("link")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("userID")
                        .HasColumnType("int");

                    b.HasKey("projectId");

                    b.HasIndex("attachmentId")
                        .IsUnique();

                    b.HasIndex("userID");

                    b.ToTable("Projects");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.ProjectUser", b =>
                {
                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.Property<int>("projectId")
                        .HasColumnType("int");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("userId", "projectId");

                    b.HasIndex("projectId");

                    b.ToTable("ProjectUsers");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Sprint", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("id");

                    b.HasIndex("UserId");

                    b.ToTable("Sprints");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AttachmentId")
                        .HasColumnType("int");

                    b.Property<string>("DescriptionAttagement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WaterfallprojectId")
                        .HasColumnType("int");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("priority")
                        .HasColumnType("int");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AttachmentId")
                        .IsUnique();

                    b.HasIndex("WaterfallprojectId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AttachmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateRegistration")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AttachmentId")
                        .IsUnique()
                        .HasFilter("[AttachmentId] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.UserTask", b =>
                {
                    b.Property<int>("userID")
                        .HasColumnType("int");

                    b.Property<int>("TaskID")
                        .HasColumnType("int");

                    b.HasKey("userID", "TaskID");

                    b.HasIndex("TaskID");

                    b.ToTable("UserTasks");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Agile", b =>
                {
                    b.HasBaseType("TaskManagementSystem.Data.Models.Project");

                    b.Property<int>("TimeForEageSprint")
                        .HasColumnType("int");

                    b.ToTable("Agiles", (string)null);
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Waterfall", b =>
                {
                    b.HasBaseType("TaskManagementSystem.Data.Models.Project");

                    b.Property<DateTime>("ExpectedEndTime")
                        .HasColumnType("datetime2");

                    b.ToTable("Waterfalls", (string)null);
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Project", b =>
                {
                    b.HasOne("TaskManagementSystem.Data.Models.Attachment", "Attachment")
                        .WithOne("Project")
                        .HasForeignKey("TaskManagementSystem.Data.Models.Project", "attachmentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TaskManagementSystem.Data.Models.User", "User")
                        .WithMany("Projects")
                        .HasForeignKey("userID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Attachment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.ProjectUser", b =>
                {
                    b.HasOne("TaskManagementSystem.Data.Models.Project", "Project")
                        .WithMany("ProjectUsers")
                        .HasForeignKey("projectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManagementSystem.Data.Models.User", "User")
                        .WithMany("ProjectUsers")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Sprint", b =>
                {
                    b.HasOne("TaskManagementSystem.Data.Models.User", "User")
                        .WithMany("Sprints")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Task", b =>
                {
                    b.HasOne("TaskManagementSystem.Data.Models.Attachment", "Attachment")
                        .WithOne("Task")
                        .HasForeignKey("TaskManagementSystem.Data.Models.Task", "AttachmentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TaskManagementSystem.Data.Models.Waterfall", null)
                        .WithMany("Tasks")
                        .HasForeignKey("WaterfallprojectId");

                    b.Navigation("Attachment");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.User", b =>
                {
                    b.HasOne("TaskManagementSystem.Data.Models.Attachment", "Attachment")
                        .WithOne("User")
                        .HasForeignKey("TaskManagementSystem.Data.Models.User", "AttachmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Attachment");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.UserTask", b =>
                {
                    b.HasOne("TaskManagementSystem.Data.Models.Task", "Task")
                        .WithMany()
                        .HasForeignKey("TaskID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManagementSystem.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("userID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Agile", b =>
                {
                    b.HasOne("TaskManagementSystem.Data.Models.Project", null)
                        .WithOne()
                        .HasForeignKey("TaskManagementSystem.Data.Models.Agile", "projectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Waterfall", b =>
                {
                    b.HasOne("TaskManagementSystem.Data.Models.Project", null)
                        .WithOne()
                        .HasForeignKey("TaskManagementSystem.Data.Models.Waterfall", "projectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Attachment", b =>
                {
                    b.Navigation("Project")
                        .IsRequired();

                    b.Navigation("Task")
                        .IsRequired();

                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Project", b =>
                {
                    b.Navigation("ProjectUsers");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.User", b =>
                {
                    b.Navigation("ProjectUsers");

                    b.Navigation("Projects");

                    b.Navigation("Sprints");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Waterfall", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
