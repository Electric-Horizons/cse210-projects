using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Evil Scientist"
        job1._company = "Doofenshmirtz Inc";
        job1._startYear = 2008;
        job1._endYear = 2015;

        Job job2 = new Job();
        job2._jobTitle = "Shift Lead";
        job2._company = "McDonalds";
        job2._startYear = 1776;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Dr Doof";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}