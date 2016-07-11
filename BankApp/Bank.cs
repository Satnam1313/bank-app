using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    static class Bank
    {
        private static List<Person> persons;
        private static List<Account> accounts;

        static Bank()
        {
            CreatePersons();
            CreateAccounts();
        }
        static void CreatePersons() 
        {
            persons = new List<Person>(){
            new Person("Narendra", "1234-5678"),
            new Person("Ilia", "2345-6789"),
            new Person("Tom", "3456-7890"),
            new Person("Syed", "4567-8901"),
            new Person("Arben", "5678-9012"),
            new Person("Patrick", "6789-0123"),
            new Person("Yin", "7890-1234"),
            new Person("Hao", "8901-2345"),
            new Person("Ilir", "9012-3456")
            };

            
        }
        static void CreateAccounts() 
        {

            accounts = new List<Account>{
            new VisaAccount(),
            new VisaAccount(50, 200),
            new SavingAccount(5000),
            new SavingAccount(),
            new CheckingAccount(2000),
            new CheckingAccount(1500, true)
            };

        }
        public static void PrintAccounts()
        {
            Console.WriteLine("All Accounts:");
            foreach (Account account in accounts)
            {
                Console.WriteLine(account.Number);
            }
            Console.WriteLine();
        }
        public static void PrintPersons()
        {
            Console.WriteLine("\nAll Account Names:");
            foreach (Person p in persons)
            {
                Console.WriteLine(p.Name);
            }
            Console.WriteLine();
        }
        public static Person GetPerson(string name)
        {
            Person pers = null;
            int ind = 0;

            foreach (Person p in persons)
            {
                if (p.Name == name)
                {
                    ind = persons.IndexOf(p);
                    break;
                }
            }
            pers = persons[ind];
            return pers;
        }
        public static Account GetAccount(string number)
        {
            Account acc = null;

            int ind = 0;

            foreach (Account a in accounts)
            {
                if (a.Number == number)
                {
                    ind = accounts.IndexOf(a);
                    break;
                }
            }

            acc = accounts[ind];
            return acc;
        }
    }
}
