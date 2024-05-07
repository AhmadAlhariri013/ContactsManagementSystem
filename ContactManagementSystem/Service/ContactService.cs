using Shared.Models;

namespace ContactManagementSystem.Service
{
    public class ContactService
    {
        private static List<Contact> contacts = new List<Contact>()
    {
        new Contact { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", PhoneNumber = "(555) 555-1234" },
        new Contact { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", PhoneNumber = "(123) 456-7890" },
        new Contact { Id = 3, FirstName = "Mike", LastName = "Lee", Email = "mike.lee@example.com", PhoneNumber = "(987) 654-3210" }
    };


        public List<Contact> GetContacts(string sortBy, bool descending)
        {
            if (sortBy == null)
            {
                return contacts; // No sorting applied
            }

            switch (sortBy)
            {
                case "FirstName":
                    return descending ? contacts.OrderByDescending(c => c.FirstName).ToList() : contacts.OrderBy(c => c.FirstName).ToList();
                case "LastName":
                    return descending ? contacts.OrderByDescending(c => c.LastName).ToList() : contacts.OrderBy(c => c.LastName).ToList();
                // Add additional cases for other sorting criteria
                default:
                    return contacts;
            }
        }

        public void CreateContact(Contact contact)
        {
            // Assign a unique ID (consider incrementing counter or GUID)
            contact.Id = contacts.Count + 1;
            contacts.Add(contact);
        }

        public Contact GetContactById(int id)
        {
            return contacts.FirstOrDefault(c => c.Id == id); // Find the first contact matching the ID
        }

        public Contact UpdateContact(Contact contact)
        {
            // Find the contact to update based on ID
            var existingContact = contacts.FirstOrDefault(c => c.Id == contact.Id);
            if (existingContact != null)
            {
                // Update properties of the existing contact object
                existingContact.FirstName = contact.FirstName;
                existingContact.LastName = contact.LastName;
                existingContact.Email = contact.Email;
                existingContact.PhoneNumber = contact.PhoneNumber;

                return existingContact;
            }

            return null;
        }

        public void DeleteContact(int id)
        {
            var contactToDelete = contacts.FirstOrDefault(c => c.Id == id);
            if (contactToDelete != null)
            {
                contacts.Remove(contactToDelete);
            }
        }
    }
}
