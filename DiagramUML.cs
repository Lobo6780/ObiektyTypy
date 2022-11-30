using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Contact
    {
        private string emailAddress;
        private string faxNumber;
        private string name;
        private string primaryContactMethod;

        public string getEmailAddress()
        {
            return this.emailAddress;
        }
        public string getFaxNumber()
        {
            return this.faxNumber;
        }
        public string getName()
        {
            return this.name;
        }
        public string getprimaryContactMethod()
        {
            return this.primaryContactMethod;
        }
        public void setEmailAddress()
        {

        }
        public void setFaxNumber()
        {

        }
        public void setName()
        {

        }
        public void setPrimaryContactMethod()
        {

        }
    }
    class AddressBook
    {
        private string name;
        private Contact contact;
        public AddressBook(Contact acontact)
        {
            this.contact = acontact;
        }
        public void getContact()
        {

        }
        public void getContacts()
        {

        }
        public string getName()
        {
            return contact.getName();
        }
        public void insertContact()
        {

        }
        public void setName()
        {

        }
    }
    class Account
    {
        private string emailAddress;
        private string name;
        private AddressBook addressbook;
        public void getAddressBook(AddressBook aaddressbook)
        {
            this.addressbook = aaddressbook;
        }
        public string getEmailAddress()
        {
            return this.emailAddress;
        }
        public string getName()
        {
            return this.name;
        }
        public void setEmailAddress()
        {

        }
        public void setName()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact c1 = new Contact();
            AddressBook a1 = new AddressBook(c1);
            Account ac1 = new Account();
            ac1.getAddressBook(a1);
        }
    }
}
