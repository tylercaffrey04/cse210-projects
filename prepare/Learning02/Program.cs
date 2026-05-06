using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();
        job1._company = "Fred's Appliance";
        job1._jobTitle = "Laborer";
        job1._startYear = 2024;
        job1._endYear = 2024;
        job1.Display();
        job2._company = "AV Broadcast";
        job2._jobTitle = "Student Sound Tech";
        job2._startYear = 2024;
        job2._endYear = 2026;
        job2.Display();

        Resume resume1 = new Resume();
        resume1._jobs.Add(job1);
        resume1._name = "Tyler";
        resume1._jobs.Add(job2);
        resume1.Display();


    }
}