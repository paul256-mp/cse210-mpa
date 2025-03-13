using System;

namespace Resumes
{
    public class Job
    {
        static void Main(string[] args)
        {
            Job job1 = new Job();
            job1._jobtitle = "Software engineerer";
            job1.company = "teyseer";
            job1.yearstarted = 2019;
            job1.yearended = 2020;

            Job job2 = new Job();
            job2._jobtitle = "Software engineerer";
            job2.company = "teyseer";
            job2.yearstarted = 2019;
            job2.yearended = 2020;

            Resume myresume = new Resume();
            myresume._Name = "paul";

            myresume.Jobs.Add(job1);
            myresume.Jobs.Add(job2);

            myresume.Display();
        }
    }
}
public class Job
{    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobtitle = "Software engineerer";
        job1._company = "teyseer";
        job1._yearstarted = 2019;
        job1._yearended = 2020;

        Job job2 = new Job();
        job2._jobtitle = "foreman";
        job2._company = "teyseer";
        job2._yearstarted = 2022;
        job2._yearended = 2023;



        Resume myresume = new Resume();
        myresume._Name = "paul";

        myresume._Jobs.Add(job1);
        myresume._Jobs.Add(job2);

        myresume Display();
    }
}


}