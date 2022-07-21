using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace DAL
{
    public interface ICustomersDAL
    {

        //return type CustomersTbl
        //Get All Customers - למנהל
        public List<CustomersTbl> GetAllCustomers();
        //Get Customer by Name & password 
        public CustomersTbl GetCustomerByNameAndPass(string name, string pass);
        //Add New Customer
        public List<CustomersTbl> PostNewCustomer(CustomersTbl NewCustomer);
        //Delete Customer By ID - למנהל
        public List<CustomersTbl> DeleteCustomerByID(short id);
       
    }
}
