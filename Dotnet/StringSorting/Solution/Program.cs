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


    public static List<string> sorting_fun(List<string> stringList)
    {
        List<string> result = new List<string>();
        result.Add(stringList[0]);
        
        for (int i = 1; i < stringList.Count; i++)
        {
            Console.WriteLine("In for {0}", i);
            int k = 0;
            while (stringList[i][0] > result[k][0])
            {
                Console.WriteLine("In while {0}", k);
                k++;
                if (k == i+1)
                {
                    result.Insert(k, stringList[i+1]);
                    break;
                }
            }
            result.Insert(k, stringList[i]);
            
            foreach( string w in result)
            {
                Console.Write(" {0},", w);
            }
            Console.WriteLine();
        }
        return result;
    }


    public static List<string> StrSort(List<string> stringList)
    {
        stringList.Sort();
        return stringList;
    }
}