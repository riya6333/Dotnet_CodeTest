using System;
using System.Data;
using System.Data.SqlClient;

namespace AssessmentADO1
{
    class Program
    {
        public static SqlConnection con = null;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        static void Main(string[] args)
        {
            ShowData();
            Employee_DataDetails();
            Console.Read();
        }

        public static SqlConnection getConnection()
        {
            con = new SqlConnection("data source=ICS-LT-F86RQ73;initial catalog=Employeemanagement1;" +
                "integrated security=true");
            con.Open();
            return con;
        }

        public static void Employee_DataDetails()
        {
            con = getConnection();
            float Emp_Sal;
            string Emp_Name, Emp_Type;
            try
            {
                Console.WriteLine("Enter Employee Name, Salary, Type (P/C) : ");

                Emp_Name = Console.ReadLine();
                Emp_Sal = Convert.ToSingle(Console.ReadLine());
                Emp_Type = Console.ReadLine();

                cmd = new SqlCommand("Employeee_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@Emp_Name", Emp_Name);
                cmd.Parameters.AddWithValue("@Emp_Sal", Emp_Sal);
                cmd.Parameters.AddWithValue("@Emp_Type", Emp_Type);

                // Since stored procedure returns Emp_No,we will  use ExecuteScalar
                int Emp_no = (int)cmd.ExecuteScalar();
                Console.WriteLine("Employee inserted successfully. Employee Number: " + Emp_no);
            }
            catch (SqlException se)
            {
                Console.WriteLine("Some SQL error occurred:" + se);
            }
        }

        public static void ShowData()
        {

            con = getConnection();
            cmd = new SqlCommand("select * from Employee_Details", con);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine("Employee Number : " + dr[0]);
                Console.WriteLine("Employee Name : " + dr[1]);
                Console.WriteLine("Employee Salary : " + dr[2]);
                Console.WriteLine("Employee Type P/C : " + dr[3]);
                Console.WriteLine();
            }
        }
    }
}
