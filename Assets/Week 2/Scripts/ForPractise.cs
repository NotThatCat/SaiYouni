using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForPractise : MonoBehaviour
{
    int lenght = 20;
    int[] arr;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("***** ForPractise *****");
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

    private string GenerateRandomString(int maxLength)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        int length = Random.Range(1, maxLength + 1);
        char[] stringChars = new char[length];

        for (int i = 0; i < length; i++)
        {
            stringChars[i] = chars[Random.Range(0, chars.Length)];
        }

        return new string(stringChars);
    }

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
        InitArray();

        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log(arr[i]);
        }
    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2()
    {
        Debug.Log("***** BaiTap2 *****");
        InitArray();
        Debug.Log("Mang: " + arr);

        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Debug.Log("Tong tat ca cac phan tu trong mang: " + sum);
    }

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    void BaiTap3()
    {
        Debug.Log("***** BaiTap3 *****");
        InitArray();
        Debug.Log("Mang: " + arr);

        int max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (max < arr[i]) max = arr[i];
        }
        Debug.Log("Phần tử lớn nhất trong mảng: " + max);
    }

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    void BaiTap4()
    {
        Debug.Log("***** BaiTap4 *****");
        InitArray();
        Debug.Log("Mang: " + arr);

        int countEven = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0) countEven++;
        }
        Debug.Log("Số lượng phần tử chẵn trong mảng: " + countEven);
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        Debug.Log("***** BaiTap5 *****");
        string[] stringArr = CreateRandomStringArray();

        for (int i = 0; i < stringArr.Length; i++)
        {
            Debug.Log(stringArr[i]);
        }
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        Debug.Log("***** BaiTap6 *****");
        string[] stringArr = CreateRandomStringArray();

        string maxStr = stringArr[0];
        for (int i = 0; i < stringArr.Length; i++)
        {
            if (stringArr[i].Length > maxStr.Length) maxStr = stringArr[i];
        }
        Debug.Log("Chuỗi dài nhất trong danh sách: " + maxStr);
    }

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    void BaiTap7()
    {
        Debug.Log("***** BaiTap7 *****");
        InitArray();
        Debug.Log("Mang: " + arr);

        int sumOdd = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0) sumOdd += arr[i];
        }
        Debug.Log("Tổng tất cả các số lẻ trong mảng: " + sumOdd);
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        Debug.Log("***** BaiTap8 *****");
        InitArray();
        Debug.Log("Mang: " + arr);

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0) Debug.Log(arr[i]);
        }
    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    void BaiTap9()
    {
        Debug.Log("***** BaiTap9 *****");
        InitArray();
        int check = Random.Range(-50, 50);
        Debug.Log("Mang: " + arr);

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == check)
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
        InitArray();
        Debug.Log("Mang: " + arr);

        int countNeg = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0) countNeg++;
        }
        Debug.Log("Số lượng các phần tử âm trong mảng: " + countNeg);
    }

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    void BaiTap11()
    {
        Debug.Log("***** BaiTap11 *****");
        InitArray();
        Debug.Log("Mang: " + arr);

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 10) Debug.Log(arr[i]);
        }
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    void BaiTap12()
    {
        Debug.Log("***** BaiTap12 *****");
        string[] stringArr = CreateRandomStringArray();
        Debug.Log("Chuoi: " + stringArr);

        string str = stringArr[0];
        for (int i = 0; i < stringArr.Length; i++)
        {
            if (str.Length > stringArr[i].Length) str = stringArr[i];
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
        // Sử dụng for để nhân đôi tất cả các phần tử trong mảng
        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log(arr[i] * 2);
        }
    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14()
    {
        Debug.Log("***** BaiTap14 *****");
        // Tạo một mảng số nguyên
        InitArray();

        Debug.Log("Mang: " + arr);
        // Sử dụng for để tìm phần tử lớn thứ hai trong mảng
        if (arr.Length < 2)
        {
            Debug.Log("Mảng có ít hơn 2 phần tử.");
            return;
        }

        int min = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (min > arr[i]) min = arr[i];
        }

        int largest = min;
        int secondLargest = min;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > largest)
            {
                secondLargest = largest;
                largest = arr[i];
            }
            else if (arr[i] > secondLargest && arr[i] != largest)
            {
                secondLargest = arr[i];
            }
        }

        Debug.Log("Số lớn thứ hai trong mảng: " + secondLargest);
    }

    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    void BaiTap15()
    {
        Debug.Log("***** BaiTap15 *****");
        // Tạo một danh sách các chuỗi
        string[] stringArr = CreateRandomStringArray();
        Debug.Log("Chuoi: " + stringArr);

        // Sử dụng for để tìm và in các chuỗi bắt đầu bằng chữ cái 'A'
        for (int i = 0; i < stringArr.Length; i++)
        {
            if (stringArr[i].Length > 0 && stringArr[i][0] == 'A')
            {
                Debug.Log(stringArr[i]);
            }
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

        // Sử dụng for để kiểm tra xem danh sách có chứa chuỗi "Hello" hay không
        for (int i = 0; i < stringArr.Length; i++)
        {
            if (stringArr[i] == check)
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

        // Sử dụng for để in ra tất cả các phần tử âm trong mảng
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                Debug.Log(arr[i]);
            }
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

        // Sử dụng for để đếm số lần xuất hiện của phần tử cụ thể đó trong mảng
        int countExist = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == check)
            {
                countExist++;
            }
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

        // Sử dụng for để tạo một danh sách mới chứa các phần tử có giá trị lớn hơn 10
        List<int> arr2 = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 10)
            {
                arr2.Add(arr[i]);
            }
        }

        Debug.Log("Danh sách mới chứa các phần tử có giá trị lớn hơn 10: " + arr2);
    }

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    void BaiTap20()
    {
        Debug.Log("***** BaiTap20 *****");
        // Tạo một danh sách các chuỗi
        string[] stringArr = CreateRandomStringArray();
        Debug.Log("Chuoi: " + stringArr);

        // Sử dụng for để in các chuỗi có độ dài lớn hơn 5 ký tự
        for (int i = 0; i < stringArr.Length; i++)
        {
            if (stringArr[i].Length > 5)
            {
                Debug.Log(stringArr[i]);
            }
        }
    }


    //// Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng
    //void BaiTap1()
    //{
    //    // Tạo một mảng số nguyên
    //    // Sử dụng foreach để in tất cả các phần tử trong mảng
    //}

    //// Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    //void BaiTap2()
    //{
    //    // Tạo một mảng số nguyên
    //    // Sử dụng foreach để tính tổng tất cả các phần tử trong mảng
    //}

    //// Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    //void BaiTap3()
    //{
    //    // Tạo một mảng số nguyên
    //    // Sử dụng foreach để tìm phần tử lớn nhất trong mảng
    //}

    //// Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    //void BaiTap4()
    //{
    //    // Tạo một mảng số nguyên
    //    // Sử dụng foreach để đếm số lượng phần tử chẵn trong mảng
    //}

    //// Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    //void BaiTap5()
    //{
    //    // Tạo một danh sách các chuỗi
    //    // Sử dụng foreach để in tất cả các chuỗi trong danh sách
    //}

    //// Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    //void BaiTap6()
    //{
    //    // Tạo một danh sách các chuỗi
    //    // Sử dụng foreach để tìm chuỗi dài nhất trong danh sách
    //}

    //// Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    //void BaiTap7()
    //{
    //    // Tạo một mảng số nguyên
    //    // Sử dụng foreach để tính tổng tất cả các số lẻ trong mảng
    //}

    //// Bài Tập 8: In Các Số Chẵn Trong Mảng
    //void BaiTap8()
    //{
    //    // Tạo một mảng số nguyên
    //    // Sử dụng foreach để in tất cả các số chẵn trong mảng
    //}

    //// Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    //void BaiTap9()
    //{
    //    // Tạo một mảng số nguyên và một phần tử cần kiểm tra
    //    // Sử dụng foreach để kiểm tra xem phần tử đó có tồn tại trong mảng không
    //}

    //// Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    //void BaiTap10()
    //{
    //    // Tạo một mảng số nguyên
    //    // Sử dụng foreach để đếm số lượng các phần tử âm trong mảng
    //}

    //// Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    //void BaiTap11()
    //{
    //    // Tạo một mảng số nguyên
    //    // Sử dụng foreach để in các số lớn hơn 10 trong mảng
    //}

    //// Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    //void BaiTap12()
    //{
    //    // Tạo một danh sách các chuỗi
    //    // Sử dụng foreach để tìm chuỗi có độ dài ngắn nhất trong danh sách
    //}

    //// Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    //void BaiTap13()
    //{
    //    // Tạo một mảng số nguyên
    //    // Sử dụng foreach để nhân đôi tất cả các phần tử trong mảng
    //}

    //// Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    //void BaiTap14()
    //{
    //    // Tạo một mảng số nguyên
    //    // Sử dụng foreach để tìm phần tử lớn thứ hai trong mảng
    //}

    //// Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    //void BaiTap15()
    //{
    //    // Tạo một danh sách các chuỗi
    //    // Sử dụng foreach để tìm và in các chuỗi bắt đầu bằng chữ cái 'A'
    //}

    //// Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    //void BaiTap16()
    //{
    //    // Tạo một danh sách các chuỗi
    //    // Sử dụng foreach để kiểm tra xem danh sách có chứa chuỗi "Hello" hay không
    //}

    //// Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    //void BaiTap17()
    //{
    //    // Tạo một mảng số nguyên
    //    // Sử dụng foreach để in ra tất cả các phần tử âm trong mảng
    //}

    //// Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    //void BaiTap18()
    //{
    //    // Tạo một mảng số nguyên và một phần tử cụ thể
    //    // Sử dụng foreach để đếm số lần xuất hiện của phần tử cụ thể đó trong mảng
    //}

    //// Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng
    //void BaiTap19()
    //{
    //    // Tạo một mảng số nguyên
    //    // Sử dụng foreach để tạo một danh sách mới chứa các phần tử có giá trị lớn hơn 10
    //}

    //// Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    //void BaiTap20()
    //{
    //    // Tạo một danh sách các chuỗi
    //    // Sử dụng foreach để in các chuỗi có độ dài lớn hơn 5 ký tự
    //}

}
