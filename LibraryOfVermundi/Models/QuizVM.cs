using LibraryOfVermundi.Data;

namespace LibraryOfVermundi.Models;

public class QuizVM
{
    private List<Question> _questions = new List<Question>();
    public List<Question> Questions => _questions;
}