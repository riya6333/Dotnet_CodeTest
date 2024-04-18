using System;


    interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }

        void ShowDetails();
    }
    public class Dayscholar : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public Dayscholar(int studentId, string name)
        {
            StudentId = studentId;
            Name = name;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine("Type: Day Scholar");
        }
    }

    public class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public Resident(int studentId, string name)
        {
            StudentId = studentId;
            Name = name;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine("Type: Resident");
        }
    }

