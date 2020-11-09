using EFDotNet001.dbcontext;
using EFDotNet001.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDotNet001
{
    class Program
    {
        static void Main(string[] args)
        {

               

            using (var dbCtx = new CollegeContextEntities())
            {

                List<Student> listing = dbCtx.Students.ToList();

                foreach (Student s in listing)
                {
                    Console.WriteLine($"Student is {s.FirstName} {s.LastName}");
                }
                Console.WriteLine($"Done {listing.Count}");

            }


            using (var dbCtx = new CollegeContextEntities())
            {

                List<Course> listing = dbCtx.Courses.ToList();

                foreach (Course c in listing)
                {
                    Console.WriteLine($"Course is {c.Title} {c.Credits}");
                }
                Console.WriteLine($"Done {listing.Count}");

            }


            using (var dbCtx = new CollegeContextEntities())
            {

                List<Enrolment> listing = dbCtx.Enrolments.ToList();

                foreach (Enrolment e in listing)
                {
                    Console.WriteLine($"Enrolment course  is {e.Course.Title} and Student is {e.Student.FirstName} {e.Student.LastName}");
                }
                Console.WriteLine($"Enrolment count is  {listing.Count}");
             
            }











        }
    }
    }

