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

    public Entry? GetEntryByTitle(string key)
    {
        return _context.Entries.FirstOrDefault(e => e.Title.Contains(key));
    }

    public List<Category> GetAllCategories()
    {
        return _context.Categories.ToList();
    }
}