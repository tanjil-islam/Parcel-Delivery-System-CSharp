using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcel_Delivery_Management_System
{
    class Customer
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string ApartmentNo { get; set; }
        public string PostalCode { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }

        public Customer(string userName, string email, string password, string phoneNo, string address,
                        string apartmentNo, string postalCode, string streetAddress, string city)
        {
            UserName = userName;
            Email = email;
            Password = password;
            PhoneNo = phoneNo;
            Address = address;
            ApartmentNo = apartmentNo;
            PostalCode = postalCode;
            StreetAddress = streetAddress;
            City = city;
        }

        public bool Register()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D76J3JK4\SQLEXPRESS;Initial Catalog=ParcelDeliveryManagement;Integrated Security=True"))
                {
                    con.Open();

                    
                    string insertUserInfoQuery = "INSERT INTO UserInfo (UserName, Password, Role) VALUES (@UserName, @Password, @Role)";
                    using (SqlCommand cmdUserInfo = new SqlCommand(insertUserInfoQuery, con))
                    {
                        cmdUserInfo.Parameters.AddWithValue("@UserName", UserName);
                        cmdUserInfo.Parameters.AddWithValue("@Password", Password);
                        cmdUserInfo.Parameters.AddWithValue("@Role", "Customer"); 

                        cmdUserInfo.ExecuteNonQuery();
                    }

                    
                    string insertCustomerInfoQuery = "INSERT INTO CustomerInfo (Cust_Name, Cust_Email, Cust_Password, Cust_Address, Cust_PhoneNo, Apartment_no, Postal_code, Street_address, City) " +
                                                     "VALUES (@UserName, @Email, @Password, @Address, @PhoneNo, @ApartmentNo, @PostalCode, @StreetAddress, @City)";
                    using (SqlCommand cmdCustomerInfo = new SqlCommand(insertCustomerInfoQuery, con))
                    {
                        cmdCustomerInfo.Parameters.AddWithValue("@UserName", UserName);
                        cmdCustomerInfo.Parameters.AddWithValue("@Email", Email);
                        cmdCustomerInfo.Parameters.AddWithValue("@Password", Password);
                        cmdCustomerInfo.Parameters.AddWithValue("@Address", Address);
                        cmdCustomerInfo.Parameters.AddWithValue("@PhoneNo", PhoneNo);
                        cmdCustomerInfo.Parameters.AddWithValue("@ApartmentNo", ApartmentNo);
                        cmdCustomerInfo.Parameters.AddWithValue("@PostalCode", PostalCode);
                        cmdCustomerInfo.Parameters.AddWithValue("@StreetAddress", StreetAddress);
                        cmdCustomerInfo.Parameters.AddWithValue("@City", City);

                        cmdCustomerInfo.ExecuteNonQuery();
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
