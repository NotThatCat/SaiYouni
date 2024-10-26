using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class GenericListBT5<T>
{
    public bool isExist(T item, List<T> items)
    {
        int index = items.IndexOf(item);
        if (index == -1) return false;
        else return true;
    }
}