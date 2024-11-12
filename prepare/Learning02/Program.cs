using System;

class Program
{
    static void Main(string[] args)
    {
        // The first job
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2021;
        job1._endYear = 2023;

        // The second job
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2023;
        job2._endYear = 2025;

        // Create a resume and add jobs to it
        Resume resume = new Resume();
        resume._name = "Quelitho Gabriel";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        // Display the resume
        resume.Display();
    }
}
