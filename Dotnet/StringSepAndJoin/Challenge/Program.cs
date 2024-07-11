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
            Console.WriteLine((SepAndJoin(inputs[i]) == answers[i]) ? "Pass" : "Fail");
        }
    }

    public static string SepAndJoin(string X)
    {    
        return X;
    }
}