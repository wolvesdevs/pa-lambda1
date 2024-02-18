namespace Lambda1.Domain.Helper
{
    public static class CommonFunc
    {
        static public string[] GetValues(string[] values, int length)
        {
            var result = new List<string>();

            foreach (var value in values)
            {
                if (value.Length >= 3)
                {
                    result.Add(value);
                }
            }

            return result.ToArray();
        }
    }
}
