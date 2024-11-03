using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class GenericListBT4<T>
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public bool RemoveItem(T item)
    {
        return items.Remove(item);
    }
}