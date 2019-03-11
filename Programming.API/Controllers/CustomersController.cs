using Programming.DAL;
using System.Collections.Generic;
using System.Web.Http;

namespace Programming.API.Controllers
{
    public class CustomersController : ApiController
    {
        CustomersDAL customerDAL = new CustomersDAL();
        public IEnumerable<Customers> Get()//Tüm Müşterileri Alalım
        {
            return customerDAL.GetAllCustomers();

        }

        public Customers Get(int id) //id ile gelen müşteriyi alalım
        {
            return customerDAL.GetCustomerById(id);

        }

        public Customers Post(Customers customer) //Dışarıdan bir customer nesnesi gelecek bir form dolduracak kullanan Kişi -customer bilgisi
        {

            return customerDAL.CreateCustomer(customer);
        }

        public Customers Put(int id, Customers customer) //Güncellemek için kullanılır.
        {
            return customerDAL.UpdateCustomer(id, customer);
        }
        
        public void Delete(int id)
        {
            customerDAL.DeleteCustomer(id);
        }




    }
}
