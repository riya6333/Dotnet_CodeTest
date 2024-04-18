using System;


namespace Concession
{
    public class TicketConcession
    {
        public const int BaseFare = 500;

        public static void CalculateConcession(int age, string name)
        {

            if (age <= 5)
                Console.WriteLine($"Little Champs - Free Ticket, Name: {name}, Age: {age}");
            else if (age > 60)
            {
                double discountedFare = BaseFare * 0.7; // 30% concession
                Console.WriteLine($"Senior Citizen - Fare: {discountedFare}, Name: {name}, Age: {age}");
            }
            else
                Console.WriteLine($"Ticket Booked - Fare: {BaseFare}, Name: {name}, Age: {age}");

        }
    }
}
