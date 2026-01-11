using System;

class Program
{
  
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2001;
        job1._endYear = 2011;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Product Manager";
        job2._startYear = 2011;
        job2._endYear = 2016;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        Console.WriteLine();
        job1.Display();
        job2.Display();
        Console.WriteLine();
        myResume.Display();
    }
}