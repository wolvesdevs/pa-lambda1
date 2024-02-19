namespace Lambda1.Domain.Helper
{
    public static class CommonFunc
    {
        public delegate bool LenCheck(string value);
        public delegate bool LenCheck3(string value, int len);

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

        static public string[] GetValues3(string[] values, int len, LenCheck3 lenCheck)
        {
            var result = new List<string>();

            foreach (var value in values)
            {
                if (lenCheck(value, len))
                {
                    result.Add(value);
                }
            }

            return result.ToArray();
        }

        static public string[] GetValues4(string[] values, Predicate<string> lenCheck)
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

        static public string[] GetValues5(string[] values, int len, Func<string, int, bool> lenCheck)
        {
            var result = new List<string>();

            foreach (var value in values)
            {
                if (lenCheck(value, len))
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

        static public bool CheckLength3(string value, int len)
        {
            return value.Length == len;
        }

        static public bool CheckLength4(string value, int len)
        {
            return value.Length >= len;
        }
    }
}
