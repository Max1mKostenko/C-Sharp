class Program
{
    static void ShowCurrentTime() => Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
    static void ShowCurrentDate() => Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));
    static void ShowCurrentDayOfWeek() => Console.WriteLine(DateTime.Now.DayOfWeek);
    static bool IsLeapYear(int year) => DateTime.IsLeapYear(year);
    static bool IsWeekend(DayOfWeek day) => day == DayOfWeek.Saturday || day == DayOfWeek.Sunday;
    static double TriangleArea(double baseLength, double height) => 0.5 * baseLength * height;
    static double RectangleArea(double width, double height) => width * height;

    static void Main(string[] args)
    {
        Action showTime = ShowCurrentTime;
        Action showDate = ShowCurrentDate;
        Action showDay = ShowCurrentDayOfWeek;

        Predicate<int> isLeap = IsLeapYear;
        Predicate<DayOfWeek> isWeekend = IsWeekend;

        Func<double, double, double> calcTriangleArea = TriangleArea;
        Func<double, double, double> calcRectangleArea = RectangleArea;

        showTime();
        showDate();
        showDay();

        Console.WriteLine(isLeap(2024));
        Console.WriteLine(isWeekend(DayOfWeek.Sunday));
        Console.WriteLine(calcTriangleArea(10, 5));
        Console.WriteLine(calcRectangleArea(8, 4));
    }
}
