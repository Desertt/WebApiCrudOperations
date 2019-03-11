using System.Collections.Generic;

namespace Programming.DAL
{
    public class CustomersDAL
    {
        NorthwindEntities db = new NorthwindEntities();//database'e bağlanmam için oluşturduğum bir class
        public IEnumerable<Customers> GetAllCustomers()//Tüm Müşterileri Döndürelim
        {
            return db.Customers;
        }

        public Customers GetCustomerById(int id) //id ile müşteri bulduran metodu yazalım
        {
            return db.Customers.Find(id);

        }

        public Customers CreateCustomer(Customers customer) //Müşteri eklemek için create metodu yazalım
        {

            db.Customers.Add(customer);
            db.SaveChanges();
            return customer;

        }

        public Customers UpdateCustomer(int id, Customers customer)//Müşteri güncellemek için create metodu yazalım
        {
            db.Entry(customer).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return customer;

        }

        public void DeleteCustomer(int id)//Müşteri silmek için delete metodu yazalım
        {
            db.Customers.Remove(db.Customers.Find(id));
            db.SaveChanges();


        }



    }
}
