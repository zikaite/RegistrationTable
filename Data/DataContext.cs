using Microsoft.EntityFrameworkCore;
using RegistrationForm.DTOs;
using RegistrationForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<CreateQuestion> CreateQuestions { get; set; }
        public DataContext(DbContextOptions<DataContext> options)
: base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CreateQuestion>().HasData(
                new CreateQuestion
                {
                    Id = 1
                });

            modelBuilder.Entity<Question>().HasData(new List<Question>()
            {
                new Question()
            {
                Id = 1,
                AnswerId = null,
                CreateQuestionId = 1,
                Name = "Reikia atlikti rangos darbus"
            }, new Question()
            {
                Id = 2,
                AnswerId = null,
                CreateQuestionId = 1,
                Name = "Rangos darbus atliks"
            }, new Question()
            {
                Id = 3,
                AnswerId = null,
                CreateQuestionId = 1,
                Name = "Verslo klientas"
            }, new Question()
            {
                Id = 4,
                AnswerId = null,
                CreateQuestionId = 1,
                Name = "Skaičiavimo metodas"
            }, new Question()
            {
                Id = 5,
                AnswerId = null,
                CreateQuestionId = 1,
                Name = "Svarbus klientas"
            }});

            modelBuilder.Entity<Answer>().HasData(new List<Answer>()

            {
            new Answer(){
                Id = 1,
                Name = "Taip",
                QuestionId = 1
            },
            new Answer()
            {
                Id = 2,
                Name = "Ne",
                QuestionId = 1
            },
            new Answer()
            {
                Id = 3,
                Name = "Metinis rangovas",
                QuestionId = 2
            },
            new Answer()
            {
                Id = 4,
                Name = "Mėnesinis rangovas",
                QuestionId = 2
            },
            new Answer()
            {
                Id = 5,
                Name = "Taip",
                QuestionId = 3
            },
            new Answer()
            {
                Id = 6,
                Name = "Ne",
                QuestionId = 3
            },
            new Answer()
            {
                Id = 7,
                Name = "Automatinis",
                QuestionId = 4
            },
            new Answer()
            {
                Id = 8,
                Name = "Rankinis",
                QuestionId = 4
            },
            new Answer()
            {
                Id = 9,
                Name = "Taip",
                QuestionId = 5
            },
            new Answer()
            {
                Id = 10,
                Name = "Ne",
                QuestionId = 5
            } 
            });
        
        } 
    }
}
