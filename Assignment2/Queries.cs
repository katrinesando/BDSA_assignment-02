using System.Xml;

namespace Assignment2;
using System.Linq;
using System.Collections.Generic;

public class Queries
{
    //1
    public static IEnumerable<string> ByRowling(IEnumerable<Wizard> wizards)
    {
        var fromCreator = from h in wizards
            where h.Creator.Equals("J.K. Rowling") 
            select h.Name;

        return fromCreator.ToList();
    }  
    public static IEnumerable<string> ByRowlingExtension(IEnumerable<Wizard> wizards)
    {
        var fromCreator = wizards.Where(h => h.Creator.Equals("J.K. Rowling")).Select(h => h.Name);

        return fromCreator.ToList();
    }
    //2
    public  static int? FindSithLord(IEnumerable<Wizard>wizards)
    {
        return (from w in wizards
            where w.Name.Contains("Darth")
            select w.Year).First();
    }
    public  static int? FindSithLordExtension(IEnumerable<Wizard>wizards)
    {
        return (wizards.Where(w => w.Name.Contains("Darth")).Select(w=>w.Year)).First() ;
    }
    //3
    public static IEnumerable<(string,int?)> FromHarryPotter(IEnumerable<Wizard> wizards)
    {
        return from w in wizards
            where w.Medium.Contains("Harry Potter")
            select(w.Name,w.Year);
    }  
    public static IEnumerable<(string name,int? year)> FromHarryPotterExtension(IEnumerable<Wizard> wizards)
    {
        var fromCreator = wizards
            .Where(h => h.Medium.Equals("Harry Potter"))
            .Select(h =>new
            { h.Name,h.Year})
            .Distinct()
            .AsEnumerable()
            .Select(h=> (h.Name,h.Year));

        return fromCreator;
    }
    
    //4
    public static IEnumerable<string> ReverseGrouped(IEnumerable<Wizard> wizards)
    {
        var reverseGrouped = (from w in wizards
            orderby w.Creator descending, w.Name
            group w by w.Creator
            into grouping
            let wnames = from h2 in grouping
                select h2.Name
            select wnames) ;
        
        foreach (var wizard in reverseGrouped)
        {
            foreach (var name in wizard)
            {
                yield return name;
            }
        }
    }
    public static IEnumerable<string> ReverseGroupedExtension(IEnumerable<Wizard> wizards)
    {
        var reverseGrouped =
            wizards.OrderByDescending(w => w.Creator).ThenBy(w => w.Name).GroupBy(w => w.Creator)
                .Select(grouping => grouping.Select(h2=>h2.Name));
        foreach (var wizard in reverseGrouped)
        {
            foreach (var name in wizard)
            {
                yield return name;
            }
        }
    }
}
