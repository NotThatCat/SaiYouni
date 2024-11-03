using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class GenericBT3<T> : PMono where T : IComparable<T>
{
    protected T data;

    public GenericBT3(T value)
    {
        data = value;
    }

    public T GetData()
    {
        return data;
    }

    public void SetData(T value)
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

    public void Swap(ref T a, ref T b)
    {
        (b, a) = (a, b);
    }
}