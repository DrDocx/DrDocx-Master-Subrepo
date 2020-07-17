﻿// <auto-generated />
using System;
using DrDocx.API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DrDocx.API.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("DrDocx.Models.Field", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("DefaultValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("FieldGroupId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MatchText")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FieldGroupId");

                    b.ToTable("Fields");
                });

            modelBuilder.Entity("DrDocx.Models.FieldGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDefaultGroup")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FieldGroups");
                });

            modelBuilder.Entity("DrDocx.Models.FieldValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("TEXT");

                    b.Property<int>("FieldId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FieldTextValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("ParentGroupId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FieldId");

                    b.HasIndex("ParentGroupId");

                    b.ToTable("FieldValues");
                });

            modelBuilder.Entity("DrDocx.Models.FieldValueGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("TEXT");

                    b.Property<int>("FieldGroupId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PatientId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FieldGroupId");

                    b.HasIndex("PatientId");

                    b.ToTable("FieldValueGroups");
                });

            modelBuilder.Entity("DrDocx.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("DrDocx.Models.ReportTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("FileName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FilePath")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ReportTemplates");
                });

            modelBuilder.Entity("DrDocx.Models.ScoreType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Formula")
                        .HasColumnType("TEXT");

                    b.Property<double>("MaxValue")
                        .HasColumnType("REAL");

                    b.Property<double>("MinValue")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ScoreType");
                });

            modelBuilder.Entity("DrDocx.Models.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("StandardizedScoreTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TestGroupId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StandardizedScoreTypeId");

                    b.HasIndex("TestGroupId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("DrDocx.Models.TestGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDefaultGroup")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TestGroups");
                });

            modelBuilder.Entity("DrDocx.Models.TestResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Percentile")
                        .HasColumnType("REAL");

                    b.Property<double>("RawScore")
                        .HasColumnType("REAL");

                    b.Property<double>("StandardizedScore")
                        .HasColumnType("REAL");

                    b.Property<int>("TestId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TestResultGroupId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.HasIndex("TestResultGroupId");

                    b.ToTable("TestResults");
                });

            modelBuilder.Entity("DrDocx.Models.TestResultGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PatientId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TestGroupInfoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.HasIndex("TestGroupInfoId");

                    b.ToTable("TestResultGroups");
                });

            modelBuilder.Entity("DrDocx.Models.Field", b =>
                {
                    b.HasOne("DrDocx.Models.FieldGroup", "FieldGroup")
                        .WithMany("Fields")
                        .HasForeignKey("FieldGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DrDocx.Models.FieldValue", b =>
                {
                    b.HasOne("DrDocx.Models.Field", "Field")
                        .WithMany()
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DrDocx.Models.FieldValueGroup", "ParentGroup")
                        .WithMany("FieldValues")
                        .HasForeignKey("ParentGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DrDocx.Models.FieldValueGroup", b =>
                {
                    b.HasOne("DrDocx.Models.FieldGroup", "FieldGroup")
                        .WithMany()
                        .HasForeignKey("FieldGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DrDocx.Models.Patient", "Patient")
                        .WithMany("FieldValueGroups")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DrDocx.Models.Test", b =>
                {
                    b.HasOne("DrDocx.Models.ScoreType", "StandardizedScoreType")
                        .WithMany()
                        .HasForeignKey("StandardizedScoreTypeId");

                    b.HasOne("DrDocx.Models.TestGroup", "TestGroup")
                        .WithMany("Tests")
                        .HasForeignKey("TestGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DrDocx.Models.TestResult", b =>
                {
                    b.HasOne("DrDocx.Models.Test", "Test")
                        .WithMany()
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DrDocx.Models.TestResultGroup", "TestResultGroup")
                        .WithMany("Tests")
                        .HasForeignKey("TestResultGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DrDocx.Models.TestResultGroup", b =>
                {
                    b.HasOne("DrDocx.Models.Patient", "Patient")
                        .WithMany("ResultGroups")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DrDocx.Models.TestGroup", "TestGroupInfo")
                        .WithMany()
                        .HasForeignKey("TestGroupInfoId");
                });
#pragma warning restore 612, 618
        }
    }
}
