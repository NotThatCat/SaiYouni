using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class GenericBT1<T> : PMono where T : IComparable<T>
{
    protected T data;

    public GenericBT1(T value)
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
}