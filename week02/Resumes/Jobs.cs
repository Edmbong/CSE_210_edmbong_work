public class Jobs
{
    public string _jobTitle = "";
    public string _company = "";
    public int _startYear = 0;
    public int _endYear = 0;

    // Method to display the job details
    public void DisplayJobDetails()
    {
       // Console.WriteLine("Display 1");
      //  Console.WriteLine("Job Title: " + _jobTitle);
       // Console.WriteLine("Company: " + _company);
       // Console.WriteLine("Start Year: " + _startYear);
       // Console.WriteLine("End Year: " + _endYear);
       // Console.WriteLine();
       // Console.WriteLine("Display 2");
       // Console.WriteLine(_jobTitle + " at " + _company + " from " + _startYear + " to " + _endYear);
       // Console.WriteLine();
       // Console.WriteLine("Display 3");
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        Console.WriteLine();
    }
}