using LifeManagement_BlazorServer.Models;

namespace LifeManagement_BlazorServer.Services;
public class ContactService 
{
    public List<Contact> ContactList = new List<Contact>();

    public List<Contact> GetContacts()
    {
        return ContactList;
    }

    public void AddContact(Contact contact)
    {
        ContactList.Add(contact);
    }
}
