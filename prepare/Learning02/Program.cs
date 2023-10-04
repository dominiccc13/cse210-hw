using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Computer Engineer";
        job1._company = "Dell";
        job1._startYear = "2019";
        job1._endYear = "2023";

        Job job2 = new Job();
        job2._jobTitle = "Project Manager";
        job2._company = "Tech Company";
        job2._startYear = "2019";
        job2._endYear = "Present";

        Resume resume = new Resume();
        resume._name = "Dominic Stefani";
        
        resume.AddJob(job1);
        resume.AddJob(job2);
        
        resume.Display();
    }
}
class Job
{
    public string _company;
    public string _jobTitle;
    public string _startYear;
    public string _endYear; 
        public void DisplayJob()
        {
            System.Console.WriteLine($"{_company} ({_jobTitle}) {_startYear}-{_endYear}");
        }
}

class Resume
{
    public string _name;
    public List<Job> _jobsList = new List<Job>();
    public void AddJob(Job job)
    {
        _jobsList.Add(job);
    }
    public void Display()
    {
        System.Console.WriteLine($"Name: {_name}");
        System.Console.WriteLine("Jobs:");
        foreach (Job job in _jobsList)
        {
            job.DisplayJob();
        }
    }

}