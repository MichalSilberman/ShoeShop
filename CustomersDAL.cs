using DAL.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class CustomersDAL : ICustomersDAL
    {
        //an instance of bd_context
        ShoesShop_dbContext _db;

        //a contructor that get an _DbContext object and restart the local props.  
        public CustomersDAL(ShoesShop_dbContext _db)
        {
            this._db = _db;
        }

        //מימוש הפונקציות של הממשק
        //2 functions to the manager-1. get all users 2. delete user.
        //2 functions to regular user-1. add new user 2. get user by name & pass.
        //Delete Customer By ID -למנהל
        public List<CustomersTbl> DeleteCustomerByID(short id)
        {
            var CustToDelete = _db.CustomersTbl.FirstOrDefault(c => c.CustId == id);
            try {
                _db.CustomersTbl.Remove(CustToDelete);
                _db.SaveChanges();
                return _db.CustomersTbl.ToList();
            }
            catch
            {
                return null;
            }
        }
        //Get All Customers - למנהל
        public List<CustomersTbl> GetAllCustomers()
        {
            return _db.CustomersTbl.ToList();
        }
        //Get Customer by Name & password 
        public CustomersTbl GetCustomerByNameAndPass(string name, string pass)
        {
            var customer = _db.CustomersTbl.FirstOrDefault(c => c.CustName == name && c.CustPassword == pass);
            return customer;
        }
        //Add New Customer
        public List<CustomersTbl> PostNewCustomer(CustomersTbl NewCustomer)
        {
            try
            {
                _db.CustomersTbl.Add(NewCustomer);
                _db.SaveChanges();
                return _db.CustomersTbl.ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}
