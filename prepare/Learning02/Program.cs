using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle="Electrical Engineer";
        job1._company="Micron";
        job1._startYear=2010;
        job1._endYear=2023;

        Job job2 = new Job();
        job2._jobTitle="Power Engineer";
        job2._company="INL";
        job2._startYear=2010;
        job2._endYear=2023;

        Resume myresume = new Resume();
        myresume._personName="Thomas Criddle";
        myresume._jobs.Add(job1);
        myresume._jobs.Add(job2);
        myresume.Display();
    }
}