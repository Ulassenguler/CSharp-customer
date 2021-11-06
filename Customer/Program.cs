using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAddRemoveEditHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer newCustomer = new Customer();
            newCustomer.ID = 4664;
            newCustomer.password = 1111;
            newCustomer.firstName = "Musa";
            newCustomer.lastName = "Uyumaz";

            Customer newCustomer2 = new Customer();
            newCustomer2.ID = 1881;
            newCustomer.password = 2222;
            newCustomer2.firstName = "Mustafa";
            newCustomer2.lastName = "Kaytez";

            Customer newCustomer3 = new Customer();
            newCustomer3.ID = 0110;
            newCustomer.password = 3333;
            newCustomer3.firstName = "Ulaş";
            newCustomer3.lastName = "Şengüler";

            CustomerManagementService customerManager = new CustomerManager();
            customerManager.AddNewCustomer(newCustomer);
            customerManager.UpdateCustomer(newCustomer2);
            customerManager.DeleteNewCustomer(newCustomer3);

            Console.ReadLine();
        }
    }

    class Customer
    {
        public int ID;

        public int password;

        public string firstName;

        public string lastName;
    }

    interface CustomerManagementService
    {
        void AddNewCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteNewCustomer(Customer customer);

    }

    class CustomerManager : CustomerManagementService
    {
        public void AddNewCustomer(Customer customer)
        {
            Console.WriteLine("|" + customer.firstName + "_" + customer.lastName + "|" + " <- Customer added. \n");
        }

        public void UpdateCustomer(Customer customer)
        {
            Console.WriteLine("|" + customer.firstName + "_" + customer.lastName + "|" + " <- Customer updated. \n");
        }
        public void DeleteNewCustomer(Customer customer)
        {
            Console.WriteLine("|" + customer.firstName + "_" + customer.lastName + "|" + " <- Customer deleted. \n");
        }
    }
}
