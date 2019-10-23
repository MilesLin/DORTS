namespace ConsoleApp1
{
    public static class IntExtensions
    {
        public static string ToMoneyPresent(this int value)
        {
            return value.ToString("###,###");
        }
    }
}