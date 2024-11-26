using Xunit.Abstractions;
using Xunit.Sdk;

namespace LibraryOfVermundiTests;

public class SearchControllerTest
{
    private Entry _entry = new Entry();
    private ITestOutputHelper _output;

    public SearchControllerTest(ITestOutputHelper output)
    {
        _output = output;
        _entry.EntryId = 1;
        _entry.RawContent =
            "Aegon, also known as \"the Rebuilder,\" ascended to the throne following the tumultuous reign of Rhaegar the Suppressor. His 25-year rule marked a period of restoration and growth for the Empire of Thasharith.\n### Key Accomplishments:\n- **Rebuilding of the Academy:** Aegon took immediate action to rebuild the Dragon's Den Academy, which had been targeted and destroyed during Rhaegar's reign. This institution was dedicated to the pursuit of knowledge and wisdom, offering courses in history, magical studies, philosophy, and sciences.\n- **Restoration of the Grand Library:** Alongside the Academy, Aegon focused on restoring the Grand Library, aiming to revive the wealth of knowledge lost during the previous reign and encourage intellectual growth.\n- **Reinstitution of the Peace Accord:** To maintain peace and harmony within the Empire, Aegon reinstated the Peace Accord, setting forth laws and principles aimed at promoting unity and discouraging conflict between nations.\n- **Establishment of the Arx:** Aegon created a protected room known as the Arx for preserving war information. He used his magic to enshrine the room and protect it from unauthorized entry, creating a magical dagger that serves as the key for entry.\n- **Revival of Cultural Traditions:** Aegon encouraged the revival of cultural traditions and practices that were suppressed during the demon king's rule, leading to a renaissance of arts and literature.\n- **Establishment of the Dragon's Council:** Aegon gathered allies, headed by Thoren Tekor, to serve as his advisors and help him rule the Empire.\n### Policies and Reforms:\n- **Promulgation of the Dragon's Decree:** Aegon issued a proclamation outlining the exact expectations and responsibilities of the aristocracy, allowing those who could not abide by the rules to be stripped of rank.\n- **Decrees of Equality:** Aegon issued decrees to ensure equal rights and opportunities for all citizens, regardless of their origin or status, reinforcing the principles of fairness and justice in the Empire.\n- **Investment in Education:** Aegon implemented policies to encourage education among all citizens, establishing more schools and learning centers throughout the Empire.\n- **Promotion of Cultural Exchange:** Aegon initiated programs to promote cultural exchange among the various regions of the Empire, fostering unity and the exchange of cultural knowledge.\n### Legacy:\nAegon's reign was characterized by a focus on rebuilding, education, and cultural revival. His efforts laid the foundation for a new era of prosperity and stability in the Empire. At the end of his reign, Aegon peacefully handed the reins of power to Thoren, confident that the provisions he had laid down would protect the people during the next cycle.";
        _entry.Title = "Aegon the Rebuilder";
        _entry.CategoryId = "H";
        _entry.Category = new Category { CategoryId = "H", Name = "History" };
        _entry.SubmissionDate = DateTime.Parse("2021-10-16");
        _entry.Contributor = new AppUser { AppUserId = 1, UserName = "vratha" };
    }

    [Fact]
    public void TestContentIteration()
    {
        int i = 0;
        string outString = "This is a test.";
        for (; i < 1 && i < _entry.Content.Length; i++)// okay, so my for loop isn't working 
        {   // the way I expected because the unit in the Content array is a PARAGRAPH, 
            // not a sentence!
            _output.WriteLine(i + ": " + _entry.Content[i] + "\n");
        }
        Assert.Equal(1, i);


    }
}