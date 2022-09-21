namespace Assignment2.Tests;

public class RecordTests
{

    // Test that fields work, focus on status
    [Fact]
    public void Return_StatusDropout()
    {
        // Arrange
       var myGuy = new ImmutableStudent(13, "Steve", "Gomez", new DateTime (2020, 8,20), new DateTime(2021, 6,15),new DateTime(2023, 6,15));

        // Act
        
        // Assert
        myGuy.Status.Should().Be(Status.Dropout);
        
    }
    [Fact]
    public void Return_StatusGraduated()
    {
        // Arrange
       var myGuy2 = new ImmutableStudent(13, "Steve", "Gomez", new DateTime (2019, 8,20), new DateTime(2022, 6,15),new DateTime(2022, 6,15));

        // Act
        
        // Assert
        myGuy2.Status.Should().Be(Status.Graduated);
        
    }
    [Fact]
    public void Return_StatusNew()
    {
        // Arrange
       var myGuy3 = new ImmutableStudent(13, "Steve", "Gomez", new DateTime (2022, 8,20), new DateTime(2025, 6,15),new DateTime(2025, 6,15));

        // Act
        
        // Assert
        myGuy3.Status.Should().Be(Status.New);
        
    }
    [Fact]
    public void Return_StatusActive()
    {
        // Arrange
       var myGuy4 = new ImmutableStudent(13, "Steve", "Gomez", new DateTime (2020, 8,20), new DateTime(2023, 6,15),new DateTime(2023, 6,15));

        // Act
        
        // Assert
        myGuy4.Status.Should().Be(Status.Active);
        
    }
    [Fact]

    public void Test_Equal(){
       // Arrange
       var myGuy5 = new ImmutableStudent(13, "Steve", "Gomez", new DateTime (2020, 8,20), new DateTime(2023, 6,15),new DateTime(2023, 6,15));
       var myGuy6 = new ImmutableStudent(13, "Steve", "Gomez", new DateTime (2020, 8,20), new DateTime(2023, 6,15),new DateTime(2023, 6,15));

        // Act
        
        // Assert
        myGuy5.Equals(myGuy6).Should().Be(true);
    }
    [Fact]
     public void Test_Equal2(){
       // Arrange
       var myGuy5 = new ImmutableStudent(13, "Steve", "Gomez", new DateTime (2020, 8,20), new DateTime(2023, 6,15),new DateTime(2023, 6,15));
       var myGuy6 = new ImmutableStudent(14, "Hank", "Shrader", new DateTime (2020, 8,20), new DateTime(2023, 6,15),new DateTime(2023, 6,15));

        // Act
        
        // Assert
        myGuy5.Equals(myGuy6).Should().Be(false);
    }


    [Fact]
     public void ToString_Test(){
       // Arrange
       var myGuy9= new ImmutableStudent(13, "Steve", "Gomez", new DateTime (2020, 8,20), new DateTime(2023, 6,15),new DateTime(2023, 6,15));


        // Act
        
        // Assert
        myGuy9.ToString().Should().Be("ImmutableStudent { Id = " +myGuy9.Id+ ", GivenName = " + myGuy9.GivenName + ", Surname = "+ myGuy9.Surname+ ", StartDate = " + myGuy9.StartDate + ", EndDate = "+ myGuy9.EndDate+", GraduationDate = " + myGuy9.GraduationDate + ", Status = " + myGuy9.Status + " }");
    }

    [Fact]
     public void ToString_Test2(){
       // Arrange
       
        var myGuy10 = new ImmutableStudent(14, "Hank", "Shrader", new DateTime (2021, 8,20), new DateTime(2022, 6,15),new DateTime(2024, 6,15));

        // Act
        
        // Assert
        myGuy10.ToString().Should().Be("ImmutableStudent { Id = " +myGuy10.Id+ ", GivenName = " + myGuy10.GivenName + ", Surname = "+ myGuy10.Surname+ ", StartDate = " + myGuy10.StartDate + ", EndDate = "+ myGuy10.EndDate+", GraduationDate = " + myGuy10.GraduationDate + ", Status = " + myGuy10.Status + " }");
    }
    
}