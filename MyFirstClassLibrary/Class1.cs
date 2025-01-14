namespace MyFirstClassLibrary
{
    public class Class1
    {
        public static string GetMessage(string appType = "")
        {
            if (appType.Trim().ToUpper() == "WEB")
            {
                return "Hello, World! This is Web App.";
            }
            else if (appType.Trim().ToUpper() == "CONSOLE")
            {
                return "Hello, World! This is Console App.";
            }

            return "Hello, World! This is Class Library";
        }
    }
}
