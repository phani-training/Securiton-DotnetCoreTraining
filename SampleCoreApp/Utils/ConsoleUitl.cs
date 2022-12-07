static class Util{
    public static string GetString(string question){
        System.Console.WriteLine(question);
        return Console.ReadLine();
    }

    public static int GetNumber(string question) => int.Parse(GetString(question));
    public static double GetDouble(string question) => double.Parse(GetString(question));
    public static DateTime GetDate() {
        int day = GetNumber("Enter the Date as 1 to 31");
        int month = GetNumber("Enter the Month");
        int year = GetNumber("Enter the Year");
        return new DateTime(year,month, day);
    }
}