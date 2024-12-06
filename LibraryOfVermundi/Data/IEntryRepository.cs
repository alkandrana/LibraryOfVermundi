using LibraryOfVermundi.Models;
namespace LibraryOfVermundi.Data;

public interface IEntryRepository
{
    public List<Entry> GetAllEntries();
    
    public List<AppUser> GetAllUsers();
    
    public Entry? GetEntryById(int id);
    public Category? GetCategoryById(string id);

    public int StoreEntry(Entry model);
    public int StoreAppUser(AppUser model);
    
    public List<Category> GetAllCategories(string mode);
    
    public int UpdateEntry(Entry model);
}