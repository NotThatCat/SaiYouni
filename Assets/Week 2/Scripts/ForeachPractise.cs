using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachPractise : MonoBehaviour
{
    //ForPractise
    int lenght = 20;
    int[] arr;

    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // In tất cả các phần tử trong mảng
        BaiTap2(); // Tính tổng các phần tử trong mảng
        BaiTap3(); // Tìm phần tử lớn nhất trong mảng
        BaiTap4(); // Đếm số lượng số chẵn trong mảng
        BaiTap5(); // In tất cả các chuỗi trong danh sách
        BaiTap6(); // Tìm chuỗi dài nhất trong danh sách
        BaiTap7(); // Tính tổng các số lẻ trong mảng
        BaiTap8(); // In các số chẵn trong mảng
        BaiTap9(); // Kiểm tra sự tồn tại của một phần tử trong mảng
        BaiTap10(); // Đếm số phần tử âm trong mảng
        BaiTap11(); // In các số lớn hơn 10 trong mảng
        BaiTap12(); // Tìm chuỗi có độ dài ngắn nhất trong danh sách
        BaiTap13(); // Nhân đôi tất cả các phần tử trong mảng
        BaiTap14(); // Tìm số lớn thứ hai trong mảng
        BaiTap15(); // Tìm chuỗi bắt đầu bằng chữ cái A
        BaiTap16(); // Kiểm tra danh sách có chứa chuỗi "Hello" không
        BaiTap17(); // In tất cả các phần tử âm trong mảng
        BaiTap18(); // Đếm số lần xuất hiện của một phần tử trong mảng
        BaiTap19(); // Tạo danh sách mới từ các phần tử lớn hơn 10
        BaiTap20(); // In các chuỗi có độ dài lớn hơn 5 ký tự
    }

    private void InitArray()
    {
        if (arr == null)
        {
            arr = new int[lenght];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Random.Range(-50, 50);
            }
        }
    }

    // Hàm tạo chuỗi ngẫu nhiên
    private string GenerateRandomString(int maxLength)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        int length = Random.Range(1, maxLength + 1); // Độ dài chuỗi ngẫu nhiên từ 1 đến maxLength
        char[] stringChars = new char[length];

        for (int i = 0; i < length; i++)
        {
            stringChars[i] = chars[Random.Range(0, chars.Length)];
        }

        return new string(stringChars);
    }

    // Hàm khởi tạo mảng chuỗi ngẫu nhiên
    private string[] CreateRandomStringArray()
    {
        int arraySize = Random.Range(0, 15);
        int maxLength = Random.Range(0, 10);
        string[] randomStrings = new string[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            randomStrings[i] = GenerateRandomString(maxLength);
        }

        return randomStrings;
    }

    // Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng
    void BaiTap1()
    {
        Debug.Log("***** BaiTap1 *****");
        // Tạo một mảng số nguyên
        InitArray();

        // Sử dụng foreach để in tất cả các phần tử trong mảng
        foreach (int item in arr)
        {
            Debug.Log(item);
        }
    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2()
    {
        Debug.Log("***** BaiTap2 *****");
        // Tạo một mảng số nguyên
        InitArray();
        Debug.Log("Mang: " + arr);

        // Sử dụng foreach để tính tổng tất cả các phần tử trong mảng
        int sum = 0;
        foreach (int item in arr)
        {
            sum += item;
        }
        Debug.Log("Tong tat ca cac phan tu trong mang: " + sum);
    }

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    void BaiTap3()
    {
        Debug.Log("***** BaiTap3 *****");
        // Tạo một mảng số nguyên
        InitArray();
        Debug.Log("Mang: " + arr);

        // Sử dụng foreach để tìm phần tử lớn nhất trong mảng
        int max = arr[0];
        foreach (int item in arr)
        {
            if (max < item) max = item;
        }
        Debug.Log("Phần tử lớn nhất trong mảng: " + max);
    }

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    void BaiTap4()
    {
        Debug.Log("***** BaiTap4 *****");
        // Tạo một mảng số nguyên
        InitArray();
        Debug.Log("Mang: " + arr);

        // Sử dụng foreach để đếm số lượng phần tử chẵn trong mảng
        int countEven = 0;
        foreach (int item in arr)
        {
            if (item % 2 == 0) countEven++;
        }
        Debug.Log("Số lượng phần tử chẵn trong mảng: " + countEven);
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        Debug.Log("***** BaiTap5 *****");
        // Tạo một danh sách các chuỗi
        string[] stringArr = CreateRandomStringArray();

        // Sử dụng foreach để in tất cả các chuỗi trong danh sách
        foreach (string item in stringArr)
        {
            Debug.Log(item);
        }
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        Debug.Log("***** BaiTap6 *****");
        // Tạo một danh sách các chuỗi
        string[] stringArr = CreateRandomStringArray();

        // Sử dụng foreach để tìm chuỗi dài nhất trong danh sách
        string maxStr = stringArr[0];
        foreach (string item in stringArr)
        {
            if (item.Length > maxStr.Length) maxStr = item;
        }
        Debug.Log("Chuỗi dài nhất trong danh sách: " + maxStr);
    }

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    void BaiTap7()
    {
        Debug.Log("***** BaiTap7 *****");
        // Tạo một mảng số nguyên
        InitArray();
        Debug.Log("Mang: " + arr);
        // Sử dụng foreach để tính tổng tất cả các số lẻ trong mảng
        int sumOdd = 0;
        foreach (int item in arr)
        {
            if (item % 2 != 0) sumOdd += item;
        }
        Debug.Log("Tổng tất cả các số lẻ trong mảng: " + sumOdd);
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        Debug.Log("***** BaiTap8 *****");
        // Tạo một mảng số nguyên
        InitArray();
        Debug.Log("Mang: " + arr);
        // Sử dụng foreach để in tất cả các số chẵn trong mảng
        foreach (int item in arr)
        {
            if (item % 2 == 0) Debug.Log(item);
        }
    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    void BaiTap9()
    {
        Debug.Log("***** BaiTap9 *****");
        // Tạo một mảng số nguyên và một phần tử cần kiểm tra
        InitArray();
        int check = Random.Range(-50, 50);
        Debug.Log("Mang: " + arr);
        // Sử dụng foreach để kiểm tra xem phần tử đó có tồn tại trong mảng không
        foreach (int item in arr)
        {
            if (item == check)
            {
                Debug.Log("Phần tử " + check + " có tồn tại trong mảng");
                return;
            }
        }
        Debug.Log("Phần tử " + check + " không tồn tại trong mảng");
    }

    // Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    void BaiTap10()
    {
        Debug.Log("***** BaiTap10 *****");
        // Tạo một mảng số nguyên
        InitArray();
        Debug.Log("Mang: " + arr);

        // Sử dụng foreach để đếm số lượng các phần tử âm trong mảng
        int countNeg = 0;
        foreach (int item in arr)
        {
            if (item < 0) countNeg++;
        }
        Debug.Log("Số lượng các phần tử âm trong mảng: " + countNeg);
    }

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    void BaiTap11()
    {
        Debug.Log("***** BaiTap11 *****");
        // Tạo một mảng số nguyên
        InitArray();
        Debug.Log("Mang: " + arr);

        // Sử dụng foreach để in các số lớn hơn 10 trong mảng
        foreach (int item in arr)
        {
            if (item > 10) Debug.Log(item);
        }
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    void BaiTap12()
    {
        Debug.Log("***** BaiTap12 *****");
        // Tạo một danh sách các chuỗi
        string[] stringArr = CreateRandomStringArray();
        Debug.Log("Chuoi: " + stringArr);

        // Sử dụng foreach để tìm chuỗi có độ dài ngắn nhất trong danh sách
        string str = stringArr[0];
        foreach (string item in stringArr)
        {
            if (str.Length > item.Length) str = item;
        }
        Debug.Log("Chuỗi có độ dài ngắn nhất trong danh sách: " + str);

    }

    // Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    void BaiTap13()
    {
        Debug.Log("***** BaiTap13 *****");
        // Tạo một mảng số nguyên
        InitArray();

        Debug.Log("Mang: " + arr);
        // Sử dụng foreach để nhân đôi tất cả các phần tử trong mảng
        foreach (int item in arr)
        {
            Debug.Log(item * 2);
        }
    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14()
    {
        Debug.Log("***** BaiTap2 *****");
        // Tạo một mảng số nguyên
        InitArray();

        Debug.Log("Mang: " + arr);
        // Sử dụng foreach để tìm phần tử lớn thứ hai trong mảng
        if (arr.Length < 2)
        {
            Debug.Log("Mảng có ít hơn 2 phần tử.");
        }

        int min = arr[0];
        foreach (int item in arr)
        {
            if (min > item) min = item;
        }

        int largest = min;
        int secondLargest = min;

        foreach (int num in arr)
        {
            if (num > largest)
            {
                secondLargest = largest;
                largest = num;
            }
            else if (num > secondLargest && num != largest)
            {
                secondLargest = num;
            }
        }
    }

    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    void BaiTap15()
    {
        Debug.Log("***** BaiTap15 *****");
        // Tạo một danh sách các chuỗi
        string[] stringArr = CreateRandomStringArray();
        Debug.Log("Chuoi: " + stringArr);

        // Sử dụng foreach để tìm và in các chuỗi bắt đầu bằng chữ cái 'A'
        foreach (string item in stringArr)
        {
            if (item[0] == 'A') Debug.Log(item);
        }
    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    void BaiTap16()
    {
        Debug.Log("***** BaiTap16 *****");
        // Tạo một danh sách các chuỗi
        string[] stringArr = CreateRandomStringArray();
        string check = "Hello";
        Debug.Log("Chuoi: " + stringArr);

        // Sử dụng foreach để kiểm tra xem danh sách có chứa chuỗi "Hello" hay không
        foreach (string item in stringArr)
        {
            if (item == check)
            {
                Debug.Log("Có chứa");
                return;
            }
        }
        Debug.Log("Không chứa");
    }

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    void BaiTap17()
    {
        Debug.Log("***** BaiTap17 *****");
        // Tạo một mảng số nguyên
        InitArray();
        Debug.Log("Mang: " + arr);

        // Sử dụng foreach để in ra tất cả các phần tử âm trong mảng
        foreach (int item in arr)
        {
            if (item < 0) Debug.Log(item);
        }
    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    void BaiTap18()
    {
        Debug.Log("***** BaiTap18 *****");
        // Tạo một mảng số nguyên và một phần tử cụ thể
        InitArray();
        int check = 0;
        Debug.Log("Mang: " + arr);
        // Sử dụng foreach để đếm số lần xuất hiện của phần tử cụ thể đó trong mảng
        int countExist = 0;
        foreach (int item in arr)
        {
            if (item < check) countExist++;
        }
        Debug.Log("Số lần xuất hiện của phần tử " + check + " là: " + countExist);
    }

    // Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng
    void BaiTap19()
    {
        Debug.Log("***** BaiTap19 *****");
        // Tạo một mảng số nguyên
        InitArray();
        Debug.Log("Mang: " + arr);
        // Sử dụng foreach để tạo một danh sách mới chứa các phần tử có giá trị lớn hơn 10
        List<int> arr2 = new List<int>();
        foreach (int item in arr)
        {
            if (item > 10) arr2.Add(item);
        }
        Debug.Log("Danh sách mới chứa các phần tử có giá trị lớn hơn 10" + arr2);
    }

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    void BaiTap20()
    {
        Debug.Log("***** BaiTap20 *****");
        // Tạo một danh sách các chuỗi
        string[] stringArr = CreateRandomStringArray();
        Debug.Log("Chuoi: " + stringArr);

        // Sử dụng foreach để in các chuỗi có độ dài lớn hơn 5 ký tự
        foreach (string item in stringArr)
        {
            if (item.Length > 5) Debug.Log(item);
        }
    }
}
