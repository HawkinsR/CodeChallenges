using System.Linq;

public class StringSorting
{
    /*
        String Sorting

        Given an input List of strings, write a method that will:
        - Sort the strings alphabetically
        - Return the resulting List of strings
    */

    public static void Main(string[] args)
    {
        List<List<string>> stringLists = new List<List<string>>();
        stringLists.Add(new List<string>{"This", "Is", "A", "List", "Of", "Words"});
        stringLists.Add(new List<string>{"Here", "Are", "Some", "More", "Strings"});
        stringLists.Add(new List<string>{"The", "Quick", "Brown", "Fox", "Jumped", "Over", "A", "Lazy", "Dog"});

        List<List<string>> answers = new List<List<string>>();
        answers.Add(new List<string>{"A", "Is", "List", "Of", "This", "Words"});
        answers.Add(new List<string>{"Are", "Here", "More", "Some", "Strings"});
        answers.Add(new List<string>{"A", "Brown", "Dog", "Fox", "Jumped", "Lazy", "Over", "Quick", "The"});
        
        for (int i = 0; i < stringLists.Count; i++)
        {
            bool correct = true;
            List<string> result = StrSort(stringLists[i]);
            for (int j = 0; j < result.Count; j++)
            {
                if (result[j] != answers[i][j])
                {
                    correct = false;
                }
            }
            Console.WriteLine( (correct) ? "Pass" : "Fail" );
        }
    }

    public static List<string> StrSort(List<string> stringList)
    {
        return stringList;
    }
}