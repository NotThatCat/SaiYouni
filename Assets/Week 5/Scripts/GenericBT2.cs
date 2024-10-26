using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class GenericBT2 : GenericBT1<int>
{
    public GenericBT2(int value) : base(value)
    {
        data = value;
    }

    public static T FindMax<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array must not be empty.");
        }

        T max = array[0];

        foreach (T item in array)
        {
            if (item.CompareTo(max) > 0)
            {
                max = item;
            }
        }

        return max;
    }
}