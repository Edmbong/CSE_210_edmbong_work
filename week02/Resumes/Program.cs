using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // Create a new instance of the Jobs class displaying the job details
        Jobs job1 = new Jobs();
        job1._jobTitle = "Software Developer";        
        job1._company = "Microsoft";        
        job1._startYear = 2020;
        job1._endYear = 2022;
        //job1.DisplayJobDetails();
        
        // Create a new instance of the Jobs class displaying the job details
        Jobs job2 = new Jobs();        
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        //job2.DisplayJobDetails();

        // Create a new instance of the Resume class displaying the job details
        Resume myResume = new Resume();
        myResume._name = "Edwin Mbong";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
        
        
    }
}