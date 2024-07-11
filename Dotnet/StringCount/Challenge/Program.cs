public class StringCount
{
    /*
    String Count

    Given an list of strings and a character L, write a method that will:
    - Count the number of strings in the list that contain character L.
*/


    public static void Main()
    {
        char[] letter = ['p', 'e', 'g', 'a'];
        List<List<string>> stringList = new List<List<string>>();
        stringList.Add(["quick", "rousing", "snappy", "sparkling", "sprightly", "spry", "stirring", "vivacious", "zippy"]);
        stringList.Add(["apple", "banana", "pear", "grape", "pineapple", "tomato"]);
        stringList.Add(["cat", "dog", "hedgehog", "bird", "turtle", "lizard", "fish"]);
        stringList.Add(["java", "dotnet", "javascript", "typescript", "python", "sql", "yaml", "groovy"]);
        int[] answer = [5, 4, 2, 3];

        for (int i = 0; i < stringList.Count; i++)
            Console.WriteLine( (checkForALetter(stringList[i], letter[i]) == answer[i]) ? "Pass" : "Fail");
    }


    public static int checkForALetter(List<string> stringList, char letter)
    {   
        return -1;
    }
}