using System;

class Student
{
    private int rollNo;
    private string name;
    private string className;
    private int semester;
    private string branch;
    private int[] marks = new int[5];

    public Student(int rollNo, string name, string className, int semester, string branch)
    {
        this.rollNo = rollNo;
        this.name = name;
        this.className = className;
        this.semester = semester;
        this.branch = branch;
    }

    public void GetMarks()
    {
        Console.WriteLine("Enter marks for 5 subjects: ");

        for (int i = 0; i < marks.Length; i++)
        {
            Console.Write("Subject" +(i+1)+ ":" + "  " );
            marks[i] = int.Parse(Console.ReadLine());
        }
    }

    public void DisplayResult()
    {
        int sum = 0;
        foreach (int mark in marks)
        {
            sum += mark;
           
        }

        double average = (double)sum / marks.Length;

        Console.WriteLine("Average Marks: {0}", average);

        bool isFailed = false;

        foreach (int mark in marks)
        {
            if (mark < 35)
            {
                isFailed = true;
                break;
            }
        }

        if (isFailed || average < 50)
        {
            Console.WriteLine("Result: Failed");
        }
        else
        {
            Console.WriteLine("Result: Passed");
        }
        
    }

    public void DisplayData()
    {
        Console.WriteLine($"Roll No: {rollNo}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Class: {className}");
        Console.WriteLine($"Semester: {semester}");
        Console.WriteLine($"Branch: {branch}");

        Console.WriteLine($"Marks: ");
        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine($"Subject {i+1}: {marks[i]}");
        }
       
        Console.ReadLine();
    }
}