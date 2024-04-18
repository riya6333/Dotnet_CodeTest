using System;
using System.Collections.Generic;

    class Scholarship
    {
    public double Merit(double marks, double fees)
    {
        double scholarshipAmount = 0;

        if (marks >= 70 && marks <= 80)
        {
            scholarshipAmount = 0.2 * fees;
        }
        else if (marks > 80 && marks <= 90)
        {
            scholarshipAmount = 0.3 * fees;
        }
        else if (marks > 90)
        {
            scholarshipAmount = 0.5 * fees;
        }

        return scholarshipAmount;
    }

}

