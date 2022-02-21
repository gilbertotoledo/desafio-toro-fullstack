namespace Infrastructure.CrossCutting
{
    public static class RandomUtils
    {
        public const string NUMBERS = "0123456789";

        public static string BuildRandomNumericString(int length)
        {
            var random = new Random();
            return new string (Enumerable.Repeat(NUMBERS, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}