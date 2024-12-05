using LibraryOfVermundi;
using Xunit.Abstractions;

namespace LibraryOfVermundiTests;

public class QuizTests
{
    private ITestOutputHelper _output;
    private QuizVM _quiz = new QuizVM();

    public QuizTests(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void TestAddQuestion()
    {
        Question q1 = new Question(new Entry {CategoryId = "B", Title = "Aegon the Rebuilder"});
        _quiz.Questions.Add(q1);
        Assert.Equal(1, _quiz.Questions.Count);
        _output.WriteLine(_quiz.Questions[0].Query);
        
    }
}