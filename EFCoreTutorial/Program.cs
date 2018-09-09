using EFCoreTutorial.Model;
using System;

namespace EFCoreTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            addBill();
        }

        public static void addBill()
        {
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
