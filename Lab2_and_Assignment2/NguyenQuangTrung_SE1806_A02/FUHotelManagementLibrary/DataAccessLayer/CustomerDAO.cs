using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUHotelManagementLibrary.Models;

namespace FUHotelManagementLibrary.DataAccessLayer
{
    public class CustomerDAO
    {
        public static List<Customer> GetCustomers()
        {
            var ListCustomers = new List<Customer>();
            try
            {
                using var db = new FuminiHotelManagementContext();
                ListCustomers = db.Customers.ToList();
            }catch (Exception ex)
            {
                
            }
            return ListCustomers;
        }

        public static void SaveCustomer(Customer c)
        {
            try
            {
                using var db = new FuminiHotelManagementContext();
                db.Customers.Add(c);
                db.SaveChanges();

            }catch (Exception ex)
            {
               throw new Exception(ex.Message);
            }
        }

        public static void UpdateCustomer(Customer c)
        {
            try
            {
                using var db = new FuminiHotelManagementContext();
                db.Entry<Customer>(c).State 
                    = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteCustomer(Customer c)
        {
            try
            {
                using var db = new FuminiHotelManagementContext();
                var p1 = db.Customers.SingleOrDefault(r => r.CustomerId == c.CustomerId)
                db.Customers.Remove(p1);
                  db.SaveChanges();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Customer GetCustomerByID(int id)
        {
            using var db = new FuminiHotelManagementContext();
            return db.Customers.SingleOrDefault(c => c.CustomerId.Equals(id));
        }
    }
}
