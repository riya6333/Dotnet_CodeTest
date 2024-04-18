using System;

    class Saledetails
    {
        private int salesNo;
        private int productNo;
        private double price;
        private DateTime dateOfSale;
        private int qty;
        private double totalAmount;

        
        public Saledetails(int salesNo, int productNo, double price, DateTime dateOfSale, int qty)
        {
            this.salesNo = salesNo;
            this.productNo = productNo;
            this.price = price;
            this.dateOfSale = dateOfSale;
            this.qty = qty;

            
            Sales();
        }

       
        public void Sales()
        {
            totalAmount = qty * price;
        }

       
        public void ShowData()
        {
            Console.WriteLine($"Sales No: {salesNo}");
            Console.WriteLine($"Product No: {productNo}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Date of Sale: {dateOfSale.ToShortDateString()}");
            Console.WriteLine($"Quantity: {qty}");
            Console.WriteLine($"Total Amount: {totalAmount}");
            Console.ReadLine();
        }

       
       
}
