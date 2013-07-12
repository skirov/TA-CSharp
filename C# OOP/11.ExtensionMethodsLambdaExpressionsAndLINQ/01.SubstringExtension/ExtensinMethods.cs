using System;
using System.Text;

public static class ExtensinMethods
{
    public static StringBuilder Substring(this StringBuilder text, int startIndex, int length)
    {
        if (startIndex<0 || length<=0)
        {
            throw new ArgumentOutOfRangeException("Length bigger than 0 and startIndex must be bigger than or euqal to 0.");
        }
        if (startIndex + length > text.Length)
        {
            throw new ArgumentOutOfRangeException("Index and length must refer to a location within the string.");
        }

        StringBuilder substring = new StringBuilder();

        for (int i = startIndex; i < startIndex + length; i++)
        {
            substring.Append(text[i]);
        }

        return substring;
    }

    public static StringBuilder Substring(this StringBuilder text, int startIndex)
    {
        if (startIndex < 0)
        {
            throw new ArgumentOutOfRangeException("StartIndex must be bigger than or euqal to 0.");
        }
        if (startIndex > text.Length)
        {
            throw new ArgumentOutOfRangeException("Index and length must refer to a location within the string.");
        }

        StringBuilder substring = new StringBuilder();

        for (int i = startIndex; i < text.Length; i++)
        {
            substring.Append(text[i]);
        }

        return substring;
    }
}