namespace Lambda1.Domain.Helper
{
    public static class CommonFunc
    {
        public delegate bool LenCheck(string value);

        static public string[] GetValues(string[] values, int length)
        {
            var result = new List<string>();

            foreach (var value in values)
            {
                if (value.Length >= length)
                {
                    result.Add(value);
                }
            }

            return result.ToArray();
        }

        static public string[] GetValues2(string[] values, LenCheck lenCheck)
        {
            var result = new List<string>();

            foreach (var value in values)
            {
                if (lenCheck(value))
                {
                    result.Add(value);
                }
            }

            return result.ToArray();
        }

        static public bool CheckLength1(string value)
        {
            return value.Length == 3;
        }

        static public bool CheckLength2(string value)
        {
            return value.Length >= 4;
        }
    }
}
