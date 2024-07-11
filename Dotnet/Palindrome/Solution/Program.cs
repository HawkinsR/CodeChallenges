public class Palindrome
{
    /*
    Palindrome

    Given an input string, write a method that will:
    - return 'true' if the string is a palindrome
    - return 'false' if the string is not a palindrome
*/

    public static void Main()
    {

        string[] s = ["abbabba", "waffles", "racecar", "pa1indrome", "full-lluf"];
        bool[] answers = [true, false, true, false, true];

        for (int i = 0; i < s.Length; i++ )
            Console.WriteLine((checkForPalindrome(s[i]) == answers[i]) ? "Pass" : "Fail");
    }


    public static bool checkForPalindrome(string s)
    {
        string reversed = "";
        for (int i = s.Length-1; i >= 0; i--)
        {
            reversed += s[i];
        }
        return s.Equals(reversed);
    }
}