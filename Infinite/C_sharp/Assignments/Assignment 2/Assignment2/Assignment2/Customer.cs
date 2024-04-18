using System;


class Customer
{
    private int customerId;
    private string Cust_name;
    private int age;
    private string phone;
    private string city;

    public Customer()
    {

    }

    public Customer(int customerId, string name, int age, string phone, string city)
    {
        this.customerId = customerId;
        this.Cust_name = name;
        this.age = age;
        this.phone = phone;
        this.city = city;
    }


    public void DisplayCustomer()
    {
        Console.WriteLine($"Customer ID: {customerId}");
        Console.WriteLine($"Name: {Cust_name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Phone: {phone}");
        Console.WriteLine($"City: {city}");
        Console.ReadLine();
    }


    ~Customer()
    {
        Console.WriteLine($"Customer object with ID {customerId} is destroyed.");
    }

    public static void DisplayCustomerStatic(Customer customer)
    {
        customer.DisplayCustomer();
    }


}
