// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistrationForm.Data;

namespace RegistrationForm.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220105175804_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RegistrationForm.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Taip",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ne",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Metinis rangovas",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 4,
                            Name = "Mėnesinis rangovas",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 5,
                            Name = "Taip",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 6,
                            Name = "Ne",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 7,
                            Name = "Automatinis",
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 8,
                            Name = "Rankinis",
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 9,
                            Name = "Taip",
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 10,
                            Name = "Ne",
                            QuestionId = 5
                        });
                });

            modelBuilder.Entity("RegistrationForm.Models.CreateQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CreateQuestions");

                    b.HasData(
                        new
                        {
                            Id = 1
                        });
                });

            modelBuilder.Entity("RegistrationForm.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnswerId")
                        .HasColumnType("int");

                    b.Property<int>("CreateQuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreateQuestionId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateQuestionId = 1,
                            Name = "Reikia atlikti rangos darbus"
                        },
                        new
                        {
                            Id = 2,
                            CreateQuestionId = 1,
                            Name = "Rangos darbus atliks"
                        },
                        new
                        {
                            Id = 3,
                            CreateQuestionId = 1,
                            Name = "Verslo klientas"
                        },
                        new
                        {
                            Id = 4,
                            CreateQuestionId = 1,
                            Name = "Skaičiavimo metodas"
                        },
                        new
                        {
                            Id = 5,
                            CreateQuestionId = 1,
                            Name = "Svarbus klientas"
                        });
                });

            modelBuilder.Entity("RegistrationForm.Models.Answer", b =>
                {
                    b.HasOne("RegistrationForm.Models.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("RegistrationForm.Models.Question", b =>
                {
                    b.HasOne("RegistrationForm.Models.CreateQuestion", null)
                        .WithMany("Questions")
                        .HasForeignKey("CreateQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RegistrationForm.Models.CreateQuestion", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("RegistrationForm.Models.Question", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
