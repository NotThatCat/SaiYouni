using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxValues : MonoBehaviour
{
    void Start()
    {
        // Giá trị lớn nhất của int
        int maxInt = int.MaxValue;
        Debug.Log("Giá trị lớn nhất của int: " + maxInt);

        // Giá trị lớn nhất của float
        float maxFloat = float.MaxValue;
        Debug.Log("Giá trị lớn nhất của float: " + maxFloat);

        // Giá trị lớn nhất của double
        double maxDouble = double.MaxValue;
        Debug.Log("Giá trị lớn nhất của double: " + maxDouble);
    }

}
