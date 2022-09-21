using System.Text.RegularExpressions;

namespace Assignment2;

public static class Extensions
{

   //1.1
   public static IEnumerable<int>Flatten<T>(this IEnumerable<int>[] xs) => xs.SelectMany(x=>x);
   
   //1.2
   public static Boolean isSecure(this Uri site) => site.ToString().ToUpper().Substring(0,5).Equals("HTTPS");

   //2
 
   public static int WordCountOnlyLetters(this string str) =>
      str.Split(new[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).
         Count(x => x.All(c=>(c>=65 && c<=90) || c>=97 && c<=122));
}
