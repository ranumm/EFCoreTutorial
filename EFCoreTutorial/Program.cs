using EFCoreTutorial.Model;
using System;
using System.Linq;

namespace EFCoreTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            getBill();
            //addBill();
        }

        public static void getBill()
        {
            var context = new SchoolContext();
            var studentsWithSameName = context.Students
                                              .Where(s => s.FirstName == getName_Bill())
                                              .ToList();
        }

        public static string getName_Bill()
        {
            return "Bill";
        }

        public static void addBill()
        {
            using (var context = new SchoolContext())
            {

                var std = new Student()
                {
                    FirstName = "Bill"
                };

                context.Students.Add(std);
                context.SaveChanges();
            }
        }
    }
}
