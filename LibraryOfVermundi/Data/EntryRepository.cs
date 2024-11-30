using LibraryOfVermundi.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryOfVermundi.Data;

public class EntryRepository : IEntryRepository
{
    private AppDbContext _context;

    public EntryRepository(AppDbContext ctx)
    {
        _context = ctx;
    }
    public List<Entry> GetAllEntries()
    {
        return _context.Entries.Include(e => e.Category).Include(
            e => e.Contributor).ToList();
    }

    public List<AppUser> GetAllUsers()
    {
        return _context.AppUsers.ToList();
    }

    public Entry? GetEntryById(int id)
    {
        var entry = _context.Entries.Include(e => e.Contributor).Include(
            e => e.Category).SingleOrDefault(e => e.EntryId == id);
        return entry;
    }
 
    public int StoreEntry(Entry model)
    {
        model.SubmissionDate = DateTime.Now;
        _context.Entries.Add(model);
        return _context.SaveChanges();
    }

    public int UpdateEntry(Entry model)
    {
        _context.Entries.Update(model);
        return _context.SaveChanges();
    }

    public Entry? GetEntryByTitle(string key)
    {
        return _context.Entries.FirstOrDefault(e => e.Title.Contains(key));
    }

    public List<Category> GetAllCategories(string mode)
    {
        List<Category> categories;
        
        if (mode == "complex")
        {
            categories = _context.Categories.Include(   // I'm kind of proud of this code, 
            c => c.Entries).OrderByDescending( // which I figured out after 
            c => c.Entries.Count).ToList(); // reading the textbook chapter on LINQ in Week 9...
        }
        else
        {
            categories = _context.Categories.ToList();
        }
        return categories;
    }
}