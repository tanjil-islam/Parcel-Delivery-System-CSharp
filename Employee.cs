using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcel_Delivery_Management_System
{
    class Employee
    {
        private string UserName { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private string PhoneNo { get; set; }
        private string Salary { get; set; }
        private readonly string Role = "Employee";

        public Employee(string userName, string email, string password, string phoneNo, string salary)
        {
            UserName = userName;
            Email = email;
            Password = password;
            PhoneNo = phoneNo;
            Salary = salary;
        }

        public bool Register()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D76J3JK4\SQLEXPRESS;Initial Catalog=ParcelDeliveryManagement;Integrated Security=True"))
                {
                    con.Open();

                   
                    using (SqlCommand insertCommand = new SqlCommand("INSERT INTO ApprovalList(UserName, Password, Role) VALUES (@userName, @userPassword, @userRole)", con))
                    {
                        insertCommand.Parameters.AddWithValue("@userName", UserName);
                        insertCommand.Parameters.AddWithValue("@userPassword", Password);
                        insertCommand.Parameters.AddWithValue("@userRole", Role);

                        int row = insertCommand.ExecuteNonQuery();

                        if (row < 1)
                        {
                            return false;
                        }
                    }

                    
                    using (SqlCommand insertCommandInformation = new SqlCommand("INSERT INTO EmployeeInfo(Emp_Name, Emp_Email, Emp_Password, Emp_Salary, Emp_PhoneNo) VALUES (@userName, @userEmail, @userPassword, @userSalary, @userPhoneNo)", con))
                    {
                        insertCommandInformation.Parameters.AddWithValue("@userName", UserName);
                        insertCommandInformation.Parameters.AddWithValue("@userEmail", Email);
                        insertCommandInformation.Parameters.AddWithValue("@userPassword", Password);
                        insertCommandInformation.Parameters.AddWithValue("@userSalary", Salary);
                        insertCommandInformation.Parameters.AddWithValue("@userPhoneNo", PhoneNo);

                        int row = insertCommandInformation.ExecuteNonQuery();

                        if (row < 1)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            catch (Exception ex)
            { 
                return false;
            }
        }
    }
}
