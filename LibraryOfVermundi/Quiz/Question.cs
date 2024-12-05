using LibraryOfVermundi.Models;
namespace LibraryOfVermundi;

public class Question
{
    private List<string> creatures = new List<string>() { "The Tower", "An Ustor", "Ustores", "A Demon", "Demons", "A Watcher", "Watchers" };
    public Question(Entry entry)
    {
        Source = entry;
    }
    public Entry Source { get; set; }

    public string Query { get; set; }
    public string UserAnswer { get; set; }

    public string CorrectAnswer
    {
        get
        {
            string ans = "";
            switch (Source.CategoryId)
            {
                case "B":
                    if (Query.Contains("Vathyri") || Query.Contains("Alaric") || Query.Contains("Callista") ||
                        Query.Contains("Kaelan") || Query.Contains("Rhaegar"))
                    {
                        ans = "The First Era";
                    } else if (Query.Contains("Aegon") || Query.Contains("Thoren") || Query.Contains("Isolde") ||
                               Query.Contains("Valorian") || Query.Contains("Morwen"))
                    {
                        ans = "The Second Era";
                    } else if (Query.Contains("Valerien") || Query.Contains("Vortigern"))
                    {
                        ans = "The Fourth Era";
                    }
                    else
                    {
                        ans = "The Third Era";
                    }
                    break;
                case "H":
                    if (Query.Contains("first"))
                    {
                        ans = "Vathyri Alaric Callista Kaelan Rhaegar";
                    } else if (Query.Contains("second"))
                    {
                        ans = "Aegon Thoren Isolde Valorian Morwen";
                    } else if (Query.Contains("fourth"))
                    {
                        ans = "Valerien Vortigern";
                    }
                    else
                    {
                        ans = "";
                    }

                    break;
                case "L":
                    foreach (string c in creatures)
                    {
                        if (Source.Title.Contains(c))
                        {
                            ans = "The Cruciatus";
                        }
                    }

                    break;
                case "M":
                    ans = "Cruciatus Elf Elven Earth Vathurian";
                    break;
                case "I":
                    ans = "Rhaegar";
                    break;
                default:
                    ans = "Vortigern";
                    break;
            }

            return ans;
        }
        
    }
    public bool Correct => CorrectAnswer.ToLower().Contains(UserAnswer.ToLower());
    public string MakeQuestion()
    {
        string q = "";
        switch (Source.CategoryId)
        {
            case ("B"):
                q = "Name the era of " + Source.Title;
                break;
            case ("L"):
                foreach (string c in creatures)
                {
                    if (Source.Title.Contains(c))
                    {
                        return "Name the point of origin of " + c;
                    }
                }

                q = "What was " + Source.Title + " known for?";
                break;
            case ("H"):
                List<string> eras = new List<string>{"first", "second", "third", "fourth"};
                Random gen = new Random();
                int rand = gen.Next(1, 4);
                q = "Name a dynast from the " + eras[rand] + " era.";
                break;
            case ("M"):
                q = "Name one of the four principal types of magic.";
                break;
            case ("I"):
                q = "Name the primary actor in the decline of magic and ascension of invention.";
                break;
            default:
                q = "Who is the last of the Tyrants?";
                break;
        }
        return q;
    }
}

