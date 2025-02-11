using Kreata.Backend.Repos.Base;
using Kreta.Shared.Enums;
using Kreta.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Repos
{
    public interface IStudentRepo : IBaseRepo<Student>
    {
        public Task<Student> GetByNameAsync(string firstName, string lastName);
        public Task<List<Student>> GetStudentByClass(int schoolYear, SchoolClassType schoolClassType);
        public Task<int> GetStudentCountAsync();
        public Task<int> GetFemaleStudentCountAsync();
        public Task<int> GetMaleStudentCountAsync();
        public Task<int> GetByBirthYearCountAsync(int BirthYear);
        public Task<int[]> GetMaleFemaleRatioAsync();
        public Task<int> GetNumberOfStudentsBornInYearAsync(int year);
        public Task<int> GetNumberOfStudentByYearAndMonthAsync(int year, int month);
    }
}
