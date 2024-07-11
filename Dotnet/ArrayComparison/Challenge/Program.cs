public class ArrayComparison
{
    /*
    ArrayComparison

    Given two arrays of strings, write a method that will:
    - Return "true" if the arrays contain the same elements in the same order
    - Return "false" if the arrays do not contain the same nmber of elements, different elements, or the same elements in differing order.
    */
    
    public static void Main()
    {
        List<string[]> arr1 = new List<string[]>();
        arr1.Add(["hello", "world"]);
        arr1.Add(["hello", "everyone"]);
        arr1.Add(["hows", "your", "day", "going?"]);
        arr1.Add(["different", "lengths"]);
        arr1.Add(["reverse", "order"]);

        List<string[]> arr2 = new List<string[]>();
        arr2.Add(["hello", "world"]);
        arr2.Add(["hello", "everyone!"]);
        arr2.Add(["hows", "your", "day", "going?"]);
        arr2.Add(["different"]);
        arr2.Add(["order", "reverse"]);

        bool[] answers = {true, false, true, false, false};
        
        for (int i = 0; i < answers.Length; i++)
            Console.WriteLine( (arrayStringsAreEqual(arr1[i], arr2[i]) == answers[i]) ? "Pass" : "Fail");
    }

    static bool arrayStringsAreEqual(string[] arr1, string[] arr2) 
    {
        return false;
    }
}