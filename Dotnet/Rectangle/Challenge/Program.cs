public class Rectangle
{
/*
    Rectangles

    Given an input string of a numerical character, write a method that will:
    - Create a rectangle with:
        - top, bottom, and sides of the input character
        - internal space made of " " characters
*/
    public static void Main(string[] args)
    {
        List<int[]> recVals = new List<int[]>();
        recVals.Add([7, 8, 6]);
        recVals.Add([2, 2, 0]);

        string[] answers = ["6666666\n6     6\n6     6\n6     6\n6     6\n6     6\n6     6\n6666666","00\n00"];

        for (int i = 0; i < recVals.Count; i++)
        {
            int cols = recVals[i][0];
            int rows = recVals[i][1];
            int line = recVals[i][2];

            Console.WriteLine( (RectangleBuilder(cols, rows, line).Equals(answers[i])) ? "Pass" : "Fail");
        }
    }

    public static string RectangleBuilder(int cols, int rows, int line)
    {
        return "";
    }
}