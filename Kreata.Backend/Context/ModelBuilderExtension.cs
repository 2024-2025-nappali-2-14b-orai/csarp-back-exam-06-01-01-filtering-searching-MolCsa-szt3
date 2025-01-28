using Kreta.Shared.Enums;
using Kreta.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="János",
                    LastName="Jegy",
                    BirthsDay=new DateTime(2022,10,10),
                    SchoolYear=9,
                    SchoolClass = SchoolClassType.ClassA,
                    EducationLevel="érettségi",
                    IsFemale=false
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Szonja",
                    LastName="Stréber",
                    BirthsDay=new DateTime(2021,4,4),
                    SchoolYear=10,
                    SchoolClass = SchoolClassType.ClassB,
                    EducationLevel="érettségi",
                    IsFemale=true
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Feri",
                    LastName="Felelő",
                    BirthsDay=new DateTime(2024,4,10),
                    SchoolYear=9,
                    SchoolClass = SchoolClassType.ClassA,
                    EducationLevel="érettségi",
                    IsFemale=false
                },
            };

            // Students
            modelBuilder.Entity<Student>().HasData(students);
        }
    }
}
