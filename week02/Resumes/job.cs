
using System;
using System.ComponentModel.DataAnnotations;

public class JobDetails
{
    public string _jobtitle;
    public string company;
    public int yearstarted;
    public int yearended;

    public void Display()
    {
        Console.WriteLine($"Job Title: {_jobtitle} {company} {yearstarted}-{yearended}");
    }
}