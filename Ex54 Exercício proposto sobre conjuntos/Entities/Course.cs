using System;
using System.Collections.Generic;
using System.Text;

namespace Ex54.Entities
{
    class Course
    {
        public int Id { get; set; }
        public string Student { get; set; }

        HashSet<Course> courses = new HashSet<Course>();


        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Course))
            {
                return false;
            }

            Course other = obj as Course;
            return Id.Equals(other.Id);
        }


        public void NewCourse(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                courses.Add(new Course { Id = x });
            }
        }

        public void Count()
        {
            Console.WriteLine("Total studants: " + courses.Count);
        }

    }
}
