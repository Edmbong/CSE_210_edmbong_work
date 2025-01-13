using System;
public class Resume
{
    public string _name;
    public List<Jobs> _jobs = new List<Jobs>();

    // Method to display the job details    
    public void DisplayResume()
    {
        Console.WriteLine($"name: {_name}");
        Console.WriteLine("Jobs:");
        //Console.WriteLine();

        // Loop through the jobs list and display the job details
        foreach (Jobs job in _jobs)
        {
            job.DisplayJobDetails();
        }
    } 
}