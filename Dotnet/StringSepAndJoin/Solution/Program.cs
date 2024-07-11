class StringSepAndJoin
{
    /*
        String Separation and Joining

        Given an input string of numerical characters, write a method that will:
        - Sort the numbers from lowest to highest
        - Remove any duplicate numbers
        - Hyphen-separate the numbers
        - Return the resulting string
    */


    static void Main(string[] args)
    {
        string[] inputs = {"1", "123", "321", "2730418695", "321321321", "5433221"};
        string[] answers = {"1", "1-2-3", "1-2-3", "0-1-2-3-4-5-6-7-8-9", "1-2-3", "1-2-3-4-5"};
        
        for(int i = 0; i < inputs.Length; i++)
        {
            Console.WriteLine((Long(inputs[i]) == answers[i]) ? "Pass" : "Fail");
        }

        //Console.Write(Short(inputs[1]));
    }

    public static string Long(string X)
    {   
        if ((X.Length == 1))
            return X;
        
        char[] charArrayUnsorted = X.ToArray();
        Array.Sort(charArrayUnsorted);
        var sortedSet = new HashSet<char>(charArrayUnsorted); 
        X = "";
        foreach (char s in sortedSet)
            X += s + "-";
        
        X = X.Remove(X.Length-1);
    
        return X;
    }

    public static string Short(string X)
    {                               //12345 => "2"
        string[] chrs = X.Select(c => new string(c, 1)).ToArray();  // break the input string into a new array of strings
        Array.Sort(chrs);                                           // sort in place
        string[] uniq = chrs.Distinct().ToArray();                    // collect the distinct strings in the array chrs, and create a new array (.ToArray)
        return String.Join("-", uniq);                              // Join the array uniq together with "-" characters, and retun it.
    }
}