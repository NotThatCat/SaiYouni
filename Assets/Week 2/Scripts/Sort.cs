using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sort : MonoBehaviour
{
    public int[] GenerateRandomArray(int length, int minValue, int maxValue)
    {
        int[] randomArray = new int[length];
        for (int i = 0; i < length; i++)
        {
            randomArray[i] = Random.Range(minValue, maxValue);
        }
        return randomArray;
    }
    //----------------------Edit below --------------------
    // Sort Algorithm 1
    //Quick sort
    public int[] QuickSort(int[] array, int leftIndex, int rightIndex)
    {
        var i = leftIndex;
        var j = rightIndex;
        var pivot = array[leftIndex];

        while (i <= j)
        {
            while (array[i] < pivot)
            {
                i++;
            }

            while (array[j] > pivot)
            {
                j--;
            }

            if (i <= j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
        }

        if (leftIndex < j)
            QuickSort(array, leftIndex, j);

        if (i < rightIndex)
            QuickSort(array, i, rightIndex);

        return array;
    }

    // Sort Algorithm 2
    //Selection sort
    public int[] SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // Hoán đổi phần tử nhỏ nhất với phần tử đầu tiên
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }

        return arr;
    }

    // Sort Algorithm 3
    //Insertion sort
    public int[] InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
        return arr;
    }

    // Sort Algorithm 4
    //Merge sort
    public int[] MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            // Gọi đệ quy cho nửa trái
            MergeSort(arr, left, mid);
            // Gọi đệ quy cho nửa phải
            MergeSort(arr, mid + 1, right);

            // Gộp hai nửa lại
            Merge(arr, left, mid, right);
        }

        return arr;
    }

    void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        // Sao chép dữ liệu vào mảng phụ
        for (int i = 0; i < n1; i++)
            leftArray[i] = arr[left + i];
        for (int i = 0; i < n2; i++)
            rightArray[i] = arr[mid + 1 + i];

        int iLeft = 0, iRight = 0, iMerged = left;

        // Gộp hai nửa lại
        while (iLeft < n1 && iRight < n2)
        {
            if (leftArray[iLeft] <= rightArray[iRight])
            {
                arr[iMerged] = leftArray[iLeft];
                iLeft++;
            }
            else
            {
                arr[iMerged] = rightArray[iRight];
                iRight++;
            }
            iMerged++;
        }

        // Sao chép các phần tử còn lại của mảng trái (nếu có)
        while (iLeft < n1)
        {
            arr[iMerged] = leftArray[iLeft];
            iLeft++;
            iMerged++;
        }

        // Sao chép các phần tử còn lại của mảng phải (nếu có)
        while (iRight < n2)
        {
            arr[iMerged] = rightArray[iRight];
            iRight++;
            iMerged++;
        }
    }

    // Sort Algorithm 5
    //Heap sort
    public int[] HeapSort(int[] arr)
    {
        int n = arr.Length;

        // Xây dựng heap (đảo ngược nửa cuối của cây)
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(arr, n, i);
        }

        // Trích xuất từng phần tử từ heap
        for (int i = n - 1; i > 0; i--)
        {
            // Di chuyển root hiện tại đến cuối
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;

            // Gọi heapify trên cây bị giảm
            Heapify(arr, i, 0);
        }

        return arr;
    }

    void Heapify(int[] arr, int n, int i)
    {
        int largest = i;   // Khởi tạo largest là root
        int left = 2 * i + 1;  // Con trái
        int right = 2 * i + 2; // Con phải

        // Nếu con trái lớn hơn root
        if (left < n && arr[left] > arr[largest])
        {
            largest = left;
        }

        // Nếu con phải lớn hơn largest
        if (right < n && arr[right] > arr[largest])
        {
            largest = right;
        }

        // Nếu largest không phải là root
        if (largest != i)
        {
            int swap = arr[i];
            arr[i] = arr[largest];
            arr[largest] = swap;

            // Đệ quy heapify sub-tree bị ảnh hưởng
            Heapify(arr, n, largest);
        }

        return arr;
    }

    //----------------------Edit above --------------------
    public void ReadArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("Element " + i + ": " + array[i]);
        }
    }

    void Start()
    {
        int[] randomNumbers = GenerateRandomArray(10, 1, 100);
        //----------------------Edit below --------------------
        //Insert Algorithm here
        QuickSort(randomNumbers, 0, randomNumbers.Length - 1);
        //----------------------Edit above --------------------
        ReadArray(randomNumbers);
    }

}
