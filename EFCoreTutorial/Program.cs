using EFCoreTutorial.Model;
using System;

namespace EFCoreTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // first do this:
            // note: need a new migration name each migration
            // PackageManagerConsole: add-migration CreateSchoolDB
            //  - or -
            // DotNet EF Tools: dotnet ef migrations add CreateSchoolDB

            // then this:
            // PackageManagerConsole: update-database –verbose
            //  - or -
            // DotNet EF Tools: dotnet ef database update
            using (var context = new SchoolContext())
            {

                var std = new Student()
                {
                    Name = "Bill"
                };

                context.Students.Add(std);
                context.SaveChanges();
            }
        }
    }
}
