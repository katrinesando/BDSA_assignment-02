namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    // Print Reversed String Test
    public void Print_namrepuS_given_Superman()
    {
        
        /* Find way to test print statments
    Action<string> reverseWord = s => {
        char[] word = s.ToCharArray();
        Array.Reverse(word);
        var reversed = new string(word);
        Console.WriteLine(reversed);
    };

    reverseWord("Superman");
    Console.ReadLine().Should().Be("namrepuS");
    */
    }

    [Fact]
    // Return product of two ints test

    public void Return_18_given_3_6(){
        
    Func<int, int, int> product = (a, b) => a * b;

    product(3,6).Should().Be(18);

    }

    [Fact]
    // Return true if int is in string
    public void Return_true_given_String__0042_and_int_42(){
        
        Func<String, int, bool> isIntInString = (word, number) =>{

        string trimmedWord = word.TrimStart('0',' ');

        int valueOfWord = Int32.Parse(trimmedWord);

            if(number == valueOfWord){
                return true;
            }
            return false;
            };

            isIntInString(" 0042",42).Should().Be(true);

         }

         
       
       [Fact]

    public void Return_false_given_String__0044_and_int_42(){
        
        Func<String, int, bool> isIntInString = (word, number) =>{

        string trimmedWord = word.TrimStart('0',' ');

        int valueOfWord = Int32.Parse(trimmedWord);

            if(number == valueOfWord){
                return true;
            }
            return false;
            };

            isIntInString(" 0044",42).Should().Be(false);

         }


}
