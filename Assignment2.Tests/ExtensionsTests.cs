namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void Test1()
    {
        // Given
        IEnumerable<int>[]xs = {new[]{1,2},new[]{3,4,5},new[]{6,7,8,9}};
        
        // When
        var result = Extensions.Flatten<int>(xs);
        // Then
        Assert.Equal(new[]{1,2,3,4,5,6,7,8,9},result);
        
    }
    [Fact]
    public void Test2()
    {
        // Given
        int[] ys= {1,2,7,8,49};
        
        // When
        var result = ys.Where(x => x % 7 == 0 && x>42);
        
        //
        result.Should().BeEquivalentTo(new[] { 49 });
    }
    [Fact]
    public void Test3()
    {
        // Given
        int[] ys= {2000,2004,1900};
        
        // When
        var result = ys.Where(x => (x % 4 == 0 && x % 100 != 0) ||(x%400==0));
        
        //
        result.Should().BeEquivalentTo(new[] {2000,2004});
    }
    [Fact]
    public void HTTPS_IsSecure()
    {
        // Given
        Uri website = new Uri("https://github.com/itu-bdsa/lecture-notes/blob/main/sessions/csharp_01/slides.md");
        
        // When
        var result = Extensions.isSecure(website);
        
        //
        result.Should().BeTrue();
    }
    [Fact]
    public void WordCount_should_be_five()
    {
        // Given
        string text = "this is a string wuuhuu";
        
        // When
        var result = Extensions.WordCountOnlyLetters(text);
        
        //
        result.Should().Be(5);
    }
    [Fact]
    public void WordCount_With_Letters()
    {
        // Given
        string text = "this is a 1 string with symbols &3#";
        
        // When
        var result = Extensions.WordCountOnlyLetters(text);
        
        //
        result.Should().Be(6);
    }
}
