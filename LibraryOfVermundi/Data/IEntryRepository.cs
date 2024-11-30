using LibraryOfVermundi.Models;
namespace LibraryOfVermundi.Data;

public interface IEntryRepository
{
    public List<Entry> GetAllEntries();
    
    public List<AppUser> GetAllUsers();
    
    public Entry? GetEntryById(int id);

    public int StoreEntry(Entry model);

    public Entry? GetEntryByTitle(string search);
    
    public List<Category> GetAllCategories(string mode);
    
    public int UpdateEntry(Entry model);
}