using LibraryOfVermundi.Models;

namespace LibraryOfVermundi.Data;

public class SeedData
{
    public static void Seed(AppDbContext ctx)
    {
        if (!ctx.Entries.Any())
        {
            Category catH = new Category { CategoryId = "H", Name = "History" };
            Category catM = new Category { CategoryId = "M", Name = "Magic" };
            Category catL = new Category { CategoryId = "L", Name = "Legend" };
            Category catI = new Category { CategoryId = "I", Name = "Invention" };
            Category catB = new Category { CategoryId = "B", Name = "Biography" };

            ctx.Categories.Add(catH);
            ctx.Categories.Add(catM);
            ctx.Categories.Add(catL);
            ctx.Categories.Add(catI);
            ctx.Categories.Add(catB);
            ctx.SaveChanges();

            AppUser contributor1 = new AppUser
            {
                AppUserId = 1,
                UserName = "vratha",
                SignUpDate = DateTime.Parse("26-7-2013")
            };

            AppUser contributor2 = new AppUser
            {
                AppUserId = 2,
                UserName = "damian",
                SignUpDate = DateTime.Parse("30-7-2013")
            };

            AppUser contributor3 = new AppUser
            {
                AppUserId = 3,
                UserName = "alkandrana",
                SignUpDate = DateTime.Parse("25-12-2013")
            };
            
            ctx.AppUsers.Add(contributor1);
            ctx.AppUsers.Add(contributor2);
            ctx.AppUsers.Add(contributor3);
            ctx.SaveChanges();

            Entry magic = new Entry
            {
                RawContent =
                    "Magic in the Empire\nMagic in the Empire of Thasharith is a complex and evolving phenomenon, deeply intertwined with the history and cycles of power within the realm. Its nature and prevalence have fluctuated throughout the Empire's history, influenced by the reigns of the dragons versus the human dynasties.\nOrigins and Early Prominence\nThe origins of magic in the Empire can be traced back to the initial War with the demons. During this time, magic played a crucial role in defending the world against the demonic incursion. THe dragon who led the humans during the War possessed a potent magic that was bane to the demons, and this power was key to their victory.\nThe Great Magical Surge\nDuring the first reign of the dragon, known as Vathyri, there was a significant increase in magical energy throughout the Empire. This period, called 'The Great Magical Surge,' led to numerous magical discoveries and advancements in spellcraft. Traditional mages and sages, who were attuned to the indigenous currents of magic, recognised the dragon's influence on magical energies.\nThe Role of Sages\nSages played a crucial role in preserving and teaching magical knowledge. They were the custodians of the mystical forms of magic in the world and were entrusted with the Dragon's Den Academy, an institution dedicated to magical studies among other disciplines.\nSuppression and Decline\nHowever, magic faced a severe setback during the reign of Rhaegar the Suppressor, a period when the demon king's spirit possessed the Emperor. Rhaegar issued decrees suppressing the practice of magic, aiming to quell potential threats to his rule and suppress any form of magic that was not of demonic origin. This led to the execution or renunciation of many sages, resulting in a significant loss of magical knowledge.\nCurrent State\nIn the present day, magic in the Empire is viewed with a mixture of skepticism and caution. The eradication of the sages and decades of estrangement from magic, coupled with the negative associations created by the demon king's reign, have led to a jaded view of magic among the citizens. However, efforts have been made by subsequent rulers to revive and study magical practices, particularly in preparation for potential future conflicts with demons.\nTechnological Integration\nIn recent times, there has been a push to integrate magical knowledge with technological advancements. Special forces have been trained in both combat and the use of new technologies, which may include magical elements. This blend of magic and technology represents the Empire's current approach to harnessing magical power while maintaining control and understanding of its applications.",
                Title = "A Brief Survey of Magic in the Empire",
                Contributor = contributor1,
                SubmissionDate = DateTime.Parse("01-08-2013")
            };
            magic.AddCategory(catH);
            magic.AddCategory(catM);
            magic.AddCategory(catI);
            ctx.Entries.Add(magic);
            ctx.SaveChanges();

            Entry ustores = new Entry
            {
                RawContent = "Definition\nUstores are creatures enslaved to the will of the demon king. They were created shortly after the war ended between humans and demons. The demon king used humans who had fallen into his power to create this race of creatures. Because they were originally human, ustores can bypass the magical prohibitions against demons entering the human world. They occasionally conduct lightning raids against the Empire.\nThe Nature of Ustores\nUstores have the ability to move through portals between the demon world and the human world. They have been used as a private army by the demon king to control and subdue people within the Empire through fear. Some ustores retain a semblance of their human consciousness, as evidenced by an attempted rebellion against the demon king, though it was ultimately crushed.\nConsequences\nThe existence of ustores highlights the ongoing threat posed by the demon world to the Empire, even during times of relative peace. Their ability to circumvent magical barriers makes them a unique and dangerous adversary that the Empire must remain vigilant against.",
                Title = "A Definition of Ustores",
                Contributor = contributor1,
                SubmissionDate = DateTime.Parse("15-08-2013")
            };
            ustores.AddCategory(catL);
            ustores.AddCategory(catM);
            ustores.AddCategory(catH);
            ctx.Entries.Add(ustores);
            ctx.SaveChanges();

            Entry dynast4 = new Entry
            {
                Title = "Kaelan the Skeptical",
                RawContent = "Kaelan the Skeptical (Years 76 - 100)\nKaelan, known as \"the Skeptical,\" ruled the Empire of Thasharith during the third human reign of the first cycle. His reign was marked by significant challenges and ultimately ended in tragedy.\nKey Events:\n• Rise of Ustores: During Kaelan's reign, ustores entered the Empire for the first time. These demon-controlled human slaves were created by the demon king through experiments on humans who had stumbled into his realm.\n• Initial Skepticism: When reports of ustores raids on settlements began to circulate, Kaelan initially discounted these rumors, as nothing of the sort had ever been seen before in the Empire.\n• Capture of the Emperor: In a shocking turn of events, a band of ustores managed to penetrate the heart of the Empire using the portal beneath the palace. They captured Emperor Kaelan and carried him off to their stronghold.\n• Empire's Response: Following Kaelan's abduction, his young son took control of the Empire and set up defenses. However, he made no attempt to rescue his father, citing the impossibility of tracking down these new antagonists.\n• Emperor's Fate: A small band of companions, mostly allies of the previous ruler Callista, managed to track the ustores back to their realm, known as the Cruciatus. There, they witnessed Kaelan's death at the hands of the demon king.\nLegacy:\nKaelan's reign marked a turning point in the Empire's history. His capture and death at the hands of the ustores and the demon king signaled the end of a period of relative peace and the beginning of a new, more dangerous era for the Empire. The events of his reign set the stage for the ascension of the demon king in the guise of Kaelan's son, ushering in a dark period for the Empire.\nKaelan's skepticism towards the initial reports of ustores serves as a cautionary tale about the dangers of dismissing unfamiliar threats. His reign is often seen as a pivotal moment that highlighted the ongoing danger posed by the demons, despite generations of peace within the Empire.",
                Contributor = contributor2,
                SubmissionDate = DateTime.Parse("2013-10-16")
            };
            
            dynast4.AddCategory(catH);
            dynast4.AddCategory(catB);
            dynast4.AddCategory(catL);
            ctx.Entries.Add(dynast4);
            ctx.SaveChanges();
        }
    }
}