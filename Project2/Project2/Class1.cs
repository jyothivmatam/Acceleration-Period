using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class PhoneBook
    {
        private Contact Contact;
        private Contact contact;
        private List<Contact> contacts { get; set; } = new List<Contact>();

        private void DisplayContactDetails(Contact contact)

        {
            Console.WriteLine($"Contact: {contact.name},{contact.Number}");
        }

        private void DisPlayContactDetails(List<Contact> contacts)
        {
            foreach(var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);

        }
        public void DisplayContact(string number)
        {
            var contact = contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }
        public void DisplayAllContact()
        {

            DisplayContactDetails(contact);
        }
        public void DisplayMatchingContacts(string searchPhase)
        {
            //named:bill
            //search 11
            var matchingContacts = contacts.Where(c => c.Name.Contains(searchPhase)).ToList();
            DisPlayContactDetails(matchingContacts);
            
              
            
        }
        }
    }

