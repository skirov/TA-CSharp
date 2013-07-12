using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BitArray64 : IEnumerable<int>
{
    private ulong input;

    public BitArray64(ulong input)
    {
        this.input = input;
    }

    #region Enumerator

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public IEnumerator<int> GetEnumerator()
    {
        int[] bits = this.ToBits();

        for (int i = 0; i < bits.Length; i++)
        {
            yield return bits[i];
        }
    }

    #endregion

    //Convert ulong number to bits
    private int[] ToBits()
    {
        ulong number = this.input;

        int[] binary = new int[64];
        int index = 0;

        while (number > 0)
        {
            binary[index] = (int)(number % 2);
            number /= 2;
            index++;
        }
        Array.Reverse(binary);
        return binary;
    }

    #region Overrides

    public override bool Equals(object obj)
    {
        if (obj == this)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override int GetHashCode()
    {
        return this.input.GetHashCode();
    }

    #endregion

    #region Operators

    public static bool operator ==(BitArray64 first, BitArray64 second)
    {
        return BitArray64.Equals(first, second);
    }

    public static bool operator !=(BitArray64 first, BitArray64 second)
    {
        return !BitArray64.Equals(first, second);
    }

    #endregion

    //Indexer
    public int this[int index]
    {
        get
        {
            if (index < 0 || index > 63)
            {
                throw new System.IndexOutOfRangeException();
            }

            int[] bits = this.ToBits();

            return bits[index];
        }
    }
}