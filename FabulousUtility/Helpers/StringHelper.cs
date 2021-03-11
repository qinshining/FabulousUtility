namespace System
{
    public static class StringHelper
    {
        public static string SafeToLower(this string This)
        {
            if (This != null)
            {
                return This.ToLower();
            }
            return string.Empty;
        }

        public static string SafeToUpper(this string This)
        {
            if (This != null)
            {
                return This.ToUpper();
            }
            return string.Empty;
        }

        public static string SafeReplace(this string This, char oldChar, char newChar)
        {
            if (This != null)
            {
                return This.Replace(oldChar, newChar);
            }
            return string.Empty;
        }

        public static string SafeReplace(this string This, string oldValue, string newValud)
        {
            if (This != null)
            {
                return This.Replace(oldValue, newValud);
            }
            return string.Empty;
        }
    }
}
