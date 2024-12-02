using LibraryOfVermundi.Models;
namespace LibraryOfVermundi.Data;

public interface IEntryRepository
{
    public List<Entry> GetAllEntries();
    
    public List<AppUser> GetAllUsers();
    
    public Entry? GetEntryById(int id);

    public int StoreEntry(Entry model);
    public int StoreAppUser(AppUser model);

    public Entry? GetEntryByTitle(string search);
    
    public List<Category> GetAllCategories(string mode);
    
    public List<Entry> GetEntriesByCategory(string category);
    
    public int UpdateEntry(Entry model);
}