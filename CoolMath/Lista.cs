using System.Collections;

namespace CoolMath;

public class PhoneBook
{
    // private List<NamePhone> _entries = new();

    private Dictionary<string, string> _items = new();

    public void Add(string name, string phone)
    {
        _items.Add(name, phone);
        // _entries.Add(new NamePhone(name, phone));
    }

    public string? FindPhoneByName(string name)
    {
        _items.TryGetValue(name, out var phone);
        return phone;

        // 10^9 items, 
        
        /*
        foreach (var entry in _entries)
        {
            if (entry.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase))
                return entry.Phone;
        }

        return null;
        */
    }

    // implementation detail
    private class NamePhone
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public NamePhone(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
    }
}
