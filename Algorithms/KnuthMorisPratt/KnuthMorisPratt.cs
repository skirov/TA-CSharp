using System;
using System.Collections;
using System.Collections.Specialized;

class KMP
{
    private string pattern;

    private int[] hArray;

    public KMP(string pattern)
    {
        if (pattern == null || pattern.Length == 0)
        {
            throw new ArgumentException
                ("The pattern may not be null or 0 lenght", "pattern");
        }

        this.pattern = pattern;
        hArray = new int[pattern.Length];
        ComputeHArray();
    }

    private void ComputeHArray()
    {
        char[] temp = null;

        char[] patternArray = pattern.ToCharArray();

        char firstChar = patternArray[0];

        hArray[0] = 0;

        for (int i = 1; i < pattern.Length; i++)
        {
            temp = SubCharArray(i, patternArray);
            hArray[i] = GetPrefixLegth(temp, firstChar);
        }
    }

    private static int GetPrefixLegth(char[] array, char charToMatch)
    {
        for (int i = 2; i < array.Length; i++)
        {
            if (array[i] == charToMatch)
            {
                if (IsSuffixExist(i, array))
                {
                    return array.Length - i;
                }
            }
        }

        return 0;
    }

    private static bool IsSuffixExist(int index, char[] array)
    {
        int k = 0;
        for (int i = index; i < array.Length; i++)
        {
            if (array[i] != array[k]) { return false; }
            k++;
        }
        return true;
    }

    private static char[] SubCharArray(int endIndex, char[] array)
    {
        char[] targetArray = new char[endIndex + 1];
        for (int i = 0; i <= endIndex; i++)
        {
            targetArray[i] = array[i];
        }
        return targetArray;
    }

    public int[] TransitionArray
    {
        get
        {
            return hArray;
        }
    }

    private static ArrayList GetOccurences(string pattern, string targetString)
    {
        ArrayList result;
        int[] transitionArray;
        char[] charArray;
        char[] patternArray;

        charArray = targetString.ToLower().ToCharArray();
        patternArray = pattern.ToLower().ToCharArray();
        result = new ArrayList();

        KMP prefixArray = new KMP(pattern);
        transitionArray = prefixArray.TransitionArray;

        int k = 0;

        for (int i = 0; i < charArray.Length; i++)
        {
            if (charArray[i] == patternArray[k])
            {
                k++;
            }
            else
            {
                int prefix = transitionArray[k];

                if (prefix + 1 > patternArray.Length &&
                    charArray[i] != patternArray[prefix + 1])
                {

                    k = 0;
                }
                else
                {
                    k = prefix;
                }
            }

            if (k == patternArray.Length)
            {
                result.Add(i - (patternArray.Length - 1));

                k = transitionArray[k - 1];
            }
        }

        return result;
    }

    static void Main()
    {
        foreach (var item in GetOccurences("ab", "abhsdsabsbabaa"))
        {
            Console.WriteLine(item);
        }
    }
}