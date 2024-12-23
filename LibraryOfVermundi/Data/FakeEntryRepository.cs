using LibraryOfVermundi.Models;

namespace LibraryOfVermundi.Data;

public class FakeEntryRepository : IEntryRepository
{
    private List<Entry> _entries = new List<Entry>();
    private List<AppUser> _users = new List<AppUser>();
    private List<Category> _categories = new List<Category>();

    public Entry? GetEntryById(int id)
    {
        return _entries.Find(r => r.EntryId == id);
    }

    public Category? GetCategoryById(string id)
    {
        return _categories.Find(r => r.CategoryId == id);
    }

    public int StoreEntry(Entry model)
    {
        int status = 0;
        if (model != null && model.Contributor != null)
        {
            model.EntryId = _entries.Count + 1;
            _entries.Add(model);
            status = 1;
        }

        return status;
    }

    public int StoreAppUser(AppUser model)
    {
        int status = 0;
        if (model != null)
        {
            model.AppUserId = _users.Count + 1;
            _users.Add(model);
        }
        return status;
    }

    public int UpdateEntry(Entry model) //PLACEHOLDER
    {
        int status = 0;
        return status;
    }
    

    public List<Category> GetAllCategories(string mode)
    {
        List<Category> categories = new List<Category>();
        foreach (Entry e in _entries)
        {
            categories.Add(e.Category);
        }
        return categories;
    }
    
    public List<AppUser> GetAllUsers()
    {
        List<AppUser> users = new List<AppUser>();
        foreach (Entry e in _entries)
        {
            users.Add(e.Contributor);
        }
        return users;
    }

    public List<Entry> GetAllEntries()
    {
        return _entries;
    }
    
    
}