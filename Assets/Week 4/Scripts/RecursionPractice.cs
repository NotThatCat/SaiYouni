using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecursionPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Tính giai thừa của một số
        BaiTap2(); // Tính tổng các số từ 1 đến n
        BaiTap3(); // Chuỗi Fibonacci
        BaiTap4(); // Đếm ngược từ n về 1
        BaiTap5(); // Tìm UCLN của hai số
    }

    // Bài Tập 1: Tính Giai Thừa Của Một Số
    void BaiTap1()
    {
        // Nhập số nguyên dương n từ bàn phím
        int n = Random.Range(0, 10);

        // Viết hàm đệ quy để tính giai thừa của n
        Debug.Log("GiaiThua " + n + ": " + GiaiThua(n));
    }

    protected int GiaiThua(int n)
    {
        if (n == 0) return 1;
        return n * GiaiThua(n - 1);
    }

    // Bài Tập 2: Tính Tổng Các Số Từ 1 Đến N
    void BaiTap2()
    {
        // Nhập số nguyên dương n từ bàn phím
        int n = Random.Range(0, 10);

        // Viết hàm đệ quy để tính tổng các số từ 1 đến n
        Debug.Log("TongN " + n + ": " + TongN(n));
    }
    protected int TongN(int n)
    {
        if (n == 0) return 0;
        return n + TongN(n - 1);
    }

    // Bài Tập 3: Chuỗi Fibonacci
    void BaiTap3()
    {
        // Nhập số nguyên n từ bàn phím
        int n = Random.Range(0, 10);

        // Viết hàm đệ quy để tính số Fibonacci thứ n
        Debug.Log("Fibonacci " + n + ": " + Fibonacci(n));
    }

    protected int Fibonacci(int n)
    {
        if (n == 1) return 1;
        if (n == 2) return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    // Bài Tập 4: Đếm Ngược
    void BaiTap4()
    {
        // Nhập số nguyên n từ bàn phím
        int n = Random.Range(0, 10);

        // Viết hàm đệ quy để đếm ngược từ n về 1
        CountBack(n);
    }

    protected virtual void CountBack(int n)
    {
        if (n == 1)
        {
            Debug.Log(n);
            return;
        }
        Debug.Log(n);
        CountBack(n - 1);

    }

    // Bài Tập 5: Tìm UCLN (Ước Chung Lớn Nhất)
    void BaiTap5()
    {
        // Nhập hai số nguyên a và b từ bàn phím
        int a = Random.Range(0, 1000);
        int b = Random.Range(0, 1000);
        // Viết hàm đệ quy để tìm UCLN của hai số theo thuật toán Euclid
        Debug.Log("UCLN " + a + " " + b + ": " + TimUCLN(a, b));
    }
    protected virtual int TimUCLN(int a, int b)
    {
        // Sử dụng thuật toán Euclid
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
