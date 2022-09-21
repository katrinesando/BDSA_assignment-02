namespace nclibrary;

public class StudentTests
{
    [Fact]
    public void should_return_1_Jens_Hansen_new()
    {
        //Arrange
        var student = new Student{id = 1, GivenName="Jens", Surname="Hansen", 
        StartDate=(new DateTime(2023, 09, 16)), EndDate=( new DateTime(2026, 07, 12)), GraduationDate = new DateTime(2026, 07, 24)};
        //Act
        var result = student.ToString();
        //Assert
        result.Should().Be("ID: 1, Name: Jens Hansen, New");
    }

    [Fact]
    public void should_return_7_Karl_Karl_Dropout()
    {
        //Arrange
        var student = new Student{id = 7, GivenName="Karl", Surname="Karl", 
        StartDate=(new DateTime(2020, 09, 16)), EndDate=( new DateTime(2021, 09, 18)), GraduationDate = new DateTime(3025, 07, 24)};
        //Act
        var result = student.ToString();
        //Assert
        result.Should().Be("ID: 7, Name: Karl Karl, Dropout");
    }

    [Fact]
    public void should_return_12_Peter_Sestoft_graduated()
    {
        //Arrange
        var student = new Student{id = 12, GivenName="Peter", Surname="Sestoft", 
        StartDate=(new DateTime(2018, 09, 16)), EndDate=( new DateTime(2021, 07, 12)), GraduationDate = new DateTime(2021, 07, 24)};
        //Act
        var result = student.ToString();
        //Assert
        result.Should().Be("ID: 12, Name: Peter Sestoft, Graduated");
    }

    [Fact]
    public void should_return_4_Jens_Jensen_Active()
    {
        //Arrange
        var student = new Student{id = 4, GivenName="Jens", Surname="Jensen", 
        StartDate=(new DateTime(2018, 09, 16)), EndDate=( new DateTime(2024, 07, 12)), GraduationDate = new DateTime(2024, 07, 24)};
        //Act
        var result = student.ToString();
        //Assert
        result.Should().Be("ID: 4, Name: Jens Jensen, Active");
    }

    [Fact]
    public void should_return_graduated_as_default_if_no_given_dates()
    {
        //Arrange
        var student = new Student{id = 4, GivenName="Jens", Surname="Jensen"};
        //Act
        var result = student.ToString();
        //Assert
        result.Should().Be("ID: 4, Name: Jens Jensen, Graduated");
    }
}
