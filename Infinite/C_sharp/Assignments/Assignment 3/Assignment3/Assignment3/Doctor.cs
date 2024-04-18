using System;
using System.Collections.Generic;

    class Doctor
    {
    private int RegnNo;
    private string Name;
    private double FeesCharged;

   
    public void SetValues(int regnNo, string name, double feesCharged)
    {
        RegnNo = regnNo;
        Name = name;
        FeesCharged = feesCharged;
    }

   
    public void Display()
    {
        Console.WriteLine("Registration Number: " + RegnNo);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Fees Charged: " + FeesCharged);
        Console.ReadLine();
    }

}

