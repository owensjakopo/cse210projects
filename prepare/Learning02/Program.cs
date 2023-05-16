using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Missionary";
        Console.WriteLine();
        job1._company = "Zimbabwe Harare Mission";
        job1._startYear = 2013;
        job1._endYear = 2015;
        
        Job job2 = new Job();
        job2._jobTitle = "Graphic Designer";
        job2._company = "DatNetComms";
        job2._startYear = 2019;
        job2._endYear = 2020;

        Job job3 = new Job();
        job3._jobTitle = "Admnistrator";
        job3._company = "Life Long Education College";
        job3._startYear = 2022;
        job3._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Owen Jakopo";

        myResume._job.Add(job1);
        myResume._job.Add(job2);
        myResume._job.Add(job3);

        myResume.Display();

    }
}