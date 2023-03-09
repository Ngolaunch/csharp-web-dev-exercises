using System;
namespace Classes_Part_2
{
	public class Course
	{
       
        public string Title  { get; set; }
        public double Credits { get; set; }
        public List<String> DaysOfWeek { get; set; }
        public List<Student> StudentRoster { get; set; }
        public Dictionary<string, int> Books  { get; set; }


        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather than
        //  just the class fields.

        public Course (string title, double credits, List<string> daysOfWeek,
            Dictionary<string, int> books, List<Student> studentRoster)
        {
            Title = title;
            Credits = credits;
            DaysOfWeek = daysOfWeek;
            Books = books;  
            StudentRoster = studentRoster;  
        }


        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Course objects equal.
    }
}

