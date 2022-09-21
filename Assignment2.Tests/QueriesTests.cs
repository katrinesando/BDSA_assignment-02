namespace Assignment2.Tests;

public class QueriesTests
{

    //1
    [Fact]
    public void wizards_ByRowling()
    {
        //Given
        IEnumerable<Wizard> wizards = WizardCollection.Create();
        
        //Where
        var result = Queries.ByRowling(wizards);
        //When
        result.Should().BeEquivalentTo(new[]{"Harry Potter","Hermonie Granger", "Dobby"});
    }
    [Fact]
    public void wizards_ByRowling_Extension()
    {
        //Given
        IEnumerable<Wizard> wizards = WizardCollection.Create();
        
        //Where
        var result = Queries.ByRowlingExtension(wizards);
        //When
        result.Should().BeEquivalentTo(new[]{"Harry Potter","Hermonie Granger", "Dobby"});
    }
    
    //2
    [Fact]
    public void FirstSithLord()
    {
        //Given
        IEnumerable<Wizard> wizards = WizardCollection.Create();
        
        //Where
        var result = Queries.FindSithLord(wizards);
        //When
        result.Should().Be(1977);
    }
    [Fact]
    public void FirstSithLord_Extension()
    {
        //Given
        IEnumerable<Wizard> wizards = WizardCollection.Create();
        
        //Where
        var result = Queries.FindSithLordExtension(wizards);
        //When
        result.Should().Be(1977);
    }
    
    //3
    [Fact]
    public void uniqList_From_HarryPotter()
    {
        //Given
        IEnumerable<Wizard> test = WizardCollection.Create();
        
        //Where
        var result = Queries.FromHarryPotter(test);
        //When
        result.Should().BeEquivalentTo(new[]{("Harry Potter",1997),("Hermonie Granger",1997), ("Dobby",1997)});
    }
    [Fact]
    public void uniqList_From_HarryPotter_Extension()
    {
        //Given
        IEnumerable<Wizard> hpNames = WizardCollection.Create();
        
        //Where
        var result = Queries.FromHarryPotterExtension(hpNames);
        //When
        result.Should().BeEquivalentTo(new[]{("Harry Potter",1997),("Hermonie Granger",1997), ("Dobby",1997)});
    }

    //4
    [Fact]
    public void groupBy_OrderBy()
    {
        //Given
        IEnumerable<Wizard> test = WizardCollection.Create();

        //Where
        var result = Queries.ReverseGrouped(test);
        //When
        result.Should().BeEquivalentTo(new[] {"Gandalf", "Merlin", "Radagast", "Sauron", "Dobby", "Harry Potter", "Hermonie Granger", "Kiki", "Darth Vader", "Luke Skywalker"});
    }
    [Fact]
    public void groupBy_OrderBy_Extension()
    {
        //Given
        IEnumerable<Wizard> test = WizardCollection.Create();

        //Where
        var result = Queries.ReverseGroupedExtension(test);
        //When
        result.Should().BeEquivalentTo(new[] {"Gandalf", "Merlin", "Radagast", "Sauron", "Dobby", "Harry Potter", "Hermonie Granger", "Kiki", "Darth Vader", "Luke Skywalker"});
    }
}
