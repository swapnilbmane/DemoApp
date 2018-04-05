﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Storage.Internal;
using schoolapp.api.models;
using System;

namespace schoolapp.api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("schoolapp.api.models.Attendence", b =>
                {
                    b.Property<int>("AttendenceId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CreatedByPersonId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsPresent");

                    b.Property<int?>("StudentId");

                    b.Property<int?>("SubTeachStdRelationId");

                    b.Property<string>("Title");

                    b.HasKey("AttendenceId");

                    b.HasIndex("CreatedByPersonId");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubTeachStdRelationId");

                    b.ToTable("Attendences");
                });

            modelBuilder.Entity("schoolapp.api.models.CommunicationMessage", b =>
                {
                    b.Property<int>("CommunicationMessageId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int?>("CreatedbyPersonId");

                    b.Property<string>("Description");

                    b.Property<int?>("NotificationEventNotificationId");

                    b.Property<int?>("ParentMessageCommunicationMessageId");

                    b.Property<string>("Title");

                    b.Property<DateTime>("Updatedon");

                    b.HasKey("CommunicationMessageId");

                    b.HasIndex("CreatedbyPersonId");

                    b.HasIndex("NotificationEventNotificationId");

                    b.HasIndex("ParentMessageCommunicationMessageId");

                    b.ToTable("CommunicationMessages");
                });

            modelBuilder.Entity("schoolapp.api.models.EventNotification", b =>
                {
                    b.Property<int>("EventNotificationId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsNotified");

                    b.Property<DateTime>("ScheduledOn");

                    b.Property<int?>("SchoolEventId");

                    b.Property<int?>("TaggedPersonPersonId");

                    b.HasKey("EventNotificationId");

                    b.HasIndex("SchoolEventId");

                    b.HasIndex("TaggedPersonPersonId");

                    b.ToTable("EventNotifications");
                });

            modelBuilder.Entity("schoolapp.api.models.Exam", b =>
                {
                    b.Property<int>("ExamId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int?>("CreatedbyPersonId");

                    b.Property<string>("Description");

                    b.Property<DateTime>("ScheduledOn");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("ExamId");

                    b.HasIndex("CreatedbyPersonId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("schoolapp.api.models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContactNumber2");

                    b.Property<int>("ContactNumber3");

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<string>("HomeAddress");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("OfficeAddress");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("schoolapp.api.models.Plan", b =>
                {
                    b.Property<int>("PlanId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime>("DurationFrom");

                    b.Property<DateTime>("DurationTo");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdatedOn");

                    b.Property<string>("descrioption");

                    b.HasKey("PlanId");

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("schoolapp.api.models.SchoolEvent", b =>
                {
                    b.Property<int>("SchoolEventId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CreatedByPersonId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<int>("EventType");

                    b.Property<DateTime>("ScheduledOn");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("SchoolEventId");

                    b.HasIndex("CreatedByPersonId");

                    b.ToTable("SchoolEvents");
                });

            modelBuilder.Entity("schoolapp.api.models.Standard", b =>
                {
                    b.Property<int>("StandardId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("StandardId");

                    b.ToTable("Standards");
                });

            modelBuilder.Entity("schoolapp.api.models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Description");

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<DateTime>("JoiningDate");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<int>("StandardId");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("StudentId");

                    b.HasIndex("StandardId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("schoolapp.api.models.StudentExam", b =>
                {
                    b.Property<int>("StudentExamId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AttendedOn");

                    b.Property<int?>("CreatedByPersonId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsPresent");

                    b.Property<int>("MarksObtained");

                    b.Property<int?>("StudentId");

                    b.Property<int?>("SubjectExamId");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("StudentExamId");

                    b.HasIndex("CreatedByPersonId");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectExamId");

                    b.ToTable("StudentExams");
                });

            modelBuilder.Entity("schoolapp.api.models.StudentParentRelation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ParentPersonId");

                    b.Property<int?>("StudentId");

                    b.HasKey("Id");

                    b.HasIndex("ParentPersonId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentParentRelations");
                });

            modelBuilder.Entity("schoolapp.api.models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("schoolapp.api.models.SubjectExam", b =>
                {
                    b.Property<int>("SubjectExamId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CreatedByPersonId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int?>("ExamId");

                    b.Property<int>("MaxMarks");

                    b.Property<DateTime>("SceduledFrom");

                    b.Property<DateTime>("ScheduledTo");

                    b.Property<int?>("SubjectId");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("SubjectExamId");

                    b.HasIndex("CreatedByPersonId");

                    b.HasIndex("ExamId");

                    b.HasIndex("SubjectId");

                    b.ToTable("SubjectExams");
                });

            modelBuilder.Entity("schoolapp.api.models.SubjectPeriod", b =>
                {
                    b.Property<int>("SubjectPeriodId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CreatedByPersonId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime>("SchecduledFrom");

                    b.Property<DateTime>("SchecduledTo");

                    b.Property<int?>("SubTeachStdRelationId");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("SubjectPeriodId");

                    b.HasIndex("CreatedByPersonId");

                    b.HasIndex("SubTeachStdRelationId");

                    b.ToTable("SubjectPeriods");
                });

            modelBuilder.Entity("schoolapp.api.models.Subscription", b =>
                {
                    b.Property<int>("SubscriptionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<bool>("IsActive");

                    b.Property<int>("PlanId");

                    b.Property<int?>("StudentId");

                    b.Property<DateTime>("SubscribedDate");

                    b.HasKey("SubscriptionId");

                    b.HasIndex("PlanId");

                    b.HasIndex("StudentId");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("schoolapp.api.models.SubTeachStdRel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("StandardId");

                    b.Property<int?>("SubjectId");

                    b.Property<int?>("TeacherPersonId");

                    b.HasKey("Id");

                    b.HasIndex("StandardId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherPersonId");

                    b.ToTable("SubTeachStdRelations");
                });

            modelBuilder.Entity("schoolapp.api.models.Attendence", b =>
                {
                    b.HasOne("schoolapp.api.models.Person", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByPersonId");

                    b.HasOne("schoolapp.api.models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");

                    b.HasOne("schoolapp.api.models.SubTeachStdRel", "SubTeachStdRelation")
                        .WithMany()
                        .HasForeignKey("SubTeachStdRelationId");
                });

            modelBuilder.Entity("schoolapp.api.models.CommunicationMessage", b =>
                {
                    b.HasOne("schoolapp.api.models.Person", "Createdby")
                        .WithMany()
                        .HasForeignKey("CreatedbyPersonId");

                    b.HasOne("schoolapp.api.models.EventNotification", "Notification")
                        .WithMany()
                        .HasForeignKey("NotificationEventNotificationId");

                    b.HasOne("schoolapp.api.models.CommunicationMessage", "ParentMessage")
                        .WithMany()
                        .HasForeignKey("ParentMessageCommunicationMessageId");
                });

            modelBuilder.Entity("schoolapp.api.models.EventNotification", b =>
                {
                    b.HasOne("schoolapp.api.models.SchoolEvent", "SchoolEvent")
                        .WithMany()
                        .HasForeignKey("SchoolEventId");

                    b.HasOne("schoolapp.api.models.Person", "TaggedPerson")
                        .WithMany()
                        .HasForeignKey("TaggedPersonPersonId");
                });

            modelBuilder.Entity("schoolapp.api.models.Exam", b =>
                {
                    b.HasOne("schoolapp.api.models.Person", "Createdby")
                        .WithMany()
                        .HasForeignKey("CreatedbyPersonId");
                });

            modelBuilder.Entity("schoolapp.api.models.SchoolEvent", b =>
                {
                    b.HasOne("schoolapp.api.models.Person", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByPersonId");
                });

            modelBuilder.Entity("schoolapp.api.models.Student", b =>
                {
                    b.HasOne("schoolapp.api.models.Standard", "Standard")
                        .WithMany()
                        .HasForeignKey("StandardId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("schoolapp.api.models.StudentExam", b =>
                {
                    b.HasOne("schoolapp.api.models.Person", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByPersonId");

                    b.HasOne("schoolapp.api.models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");

                    b.HasOne("schoolapp.api.models.SubjectExam", "SubjectExam")
                        .WithMany()
                        .HasForeignKey("SubjectExamId");
                });

            modelBuilder.Entity("schoolapp.api.models.StudentParentRelation", b =>
                {
                    b.HasOne("schoolapp.api.models.Person", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentPersonId");

                    b.HasOne("schoolapp.api.models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("schoolapp.api.models.SubjectExam", b =>
                {
                    b.HasOne("schoolapp.api.models.Person", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByPersonId");

                    b.HasOne("schoolapp.api.models.Exam", "Exam")
                        .WithMany()
                        .HasForeignKey("ExamId");

                    b.HasOne("schoolapp.api.models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId");
                });

            modelBuilder.Entity("schoolapp.api.models.SubjectPeriod", b =>
                {
                    b.HasOne("schoolapp.api.models.Person", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByPersonId");

                    b.HasOne("schoolapp.api.models.SubTeachStdRel", "SubTeachStdRelation")
                        .WithMany()
                        .HasForeignKey("SubTeachStdRelationId");
                });

            modelBuilder.Entity("schoolapp.api.models.Subscription", b =>
                {
                    b.HasOne("schoolapp.api.models.Plan", "Plan")
                        .WithMany()
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("schoolapp.api.models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("schoolapp.api.models.SubTeachStdRel", b =>
                {
                    b.HasOne("schoolapp.api.models.Standard", "Standard")
                        .WithMany()
                        .HasForeignKey("StandardId");

                    b.HasOne("schoolapp.api.models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId");

                    b.HasOne("schoolapp.api.models.Person", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherPersonId");
                });
#pragma warning restore 612, 618
        }
    }
}
