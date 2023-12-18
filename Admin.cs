using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcel_Delivery_Management_System
{
    class Admin
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string ApartmentNo { get; set; }
        public string PostalCode { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }

        public Admin(string userName, string email, string password, string address, string phoneNo, string apartmentNo, string postalCode, string streetAddress, string city)
        {
            UserName = userName;
            Email = email;
            Password = password;
            Address = address;
            PhoneNo = phoneNo;
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

                    string insertUserInfoQuery = "INSERT INTO ApprovalList (UserName, Password, Role) VALUES (@UserName, @Password, @Role)";
                    using (SqlCommand cmdUserInfo = new SqlCommand(insertUserInfoQuery, con))
                    {
                        cmdUserInfo.Parameters.AddWithValue("@UserName", UserName);
                        cmdUserInfo.Parameters.AddWithValue("@Password", Password);
                        cmdUserInfo.Parameters.AddWithValue("@Role", "Admin"); 

                        cmdUserInfo.ExecuteNonQuery();
                    }

                    // Insert into AdminInfo table
                    string insertAdminInfoQuery = "INSERT INTO AdminInfo (Admin_Name, Admin_Email, Admin_Password, Admin_Address, Admin_PhoneNo, Apartment_no, Postal_code, Street_address, City) " +
                                                 "VALUES (@UserName, @Email, @Password, @Address, @PhoneNo, @ApartmentNo, @PostalCode, @StreetAddress, @City)";
                    using (SqlCommand cmdAdminInfo = new SqlCommand(insertAdminInfoQuery, con))
                    {
                        cmdAdminInfo.Parameters.AddWithValue("@UserName", UserName);
                        cmdAdminInfo.Parameters.AddWithValue("@Email", Email);
                        cmdAdminInfo.Parameters.AddWithValue("@Password", Password);
                        cmdAdminInfo.Parameters.AddWithValue("@Address", Address);
                        cmdAdminInfo.Parameters.AddWithValue("@PhoneNo", PhoneNo);
                        cmdAdminInfo.Parameters.AddWithValue("@ApartmentNo", ApartmentNo);
                        cmdAdminInfo.Parameters.AddWithValue("@PostalCode", PostalCode);
                        cmdAdminInfo.Parameters.AddWithValue("@StreetAddress", StreetAddress);
                        cmdAdminInfo.Parameters.AddWithValue("@City", City);

                        cmdAdminInfo.ExecuteNonQuery();
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
