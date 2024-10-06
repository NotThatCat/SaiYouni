using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class IfStatementPractise : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("***** IfStatementPractise *****");
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra số dương, âm, hoặc bằng 0
        BaiTap2(); // Kiểm tra số chẵn hay lẻ
        BaiTap3(); // Kiểm tra điều kiện thi đỗ
        BaiTap4(); // Tìm số lớn nhất trong hai số
        BaiTap5(); // Kiểm tra điều kiện mua hàng
        BaiTap6(); // Kiểm tra năm nhuận
        BaiTap7(); // Tính giá vé xem phim
        BaiTap8(); // Kiểm tra học sinh xuất sắc
        BaiTap9(); // So sánh ba số
        BaiTap10(); // Tính tiền lương
        BaiTap11(); // Kiểm tra điều kiện vào câu lạc bộ
        BaiTap12(); // Phân loại học sinh
        BaiTap13(); // Tính tiền điện
        BaiTap14(); // Kiểm tra điều kiện thăng chức
        BaiTap15(); // Kiểm tra điều kiện miễn phí vận chuyển
        BaiTap16(); // Tính thuế thu nhập cá nhân
        BaiTap17(); // Tính điểm trung bình của môn học
        BaiTap18(); // Kiểm tra điều kiện nhập hàng
        BaiTap19(); // Tìm số lớn hơn 10
        BaiTap20(); // Kiểm tra điều kiện đăng ký khóa học
    }

    // Bài Tập 1: Kiểm Tra Số Dương, Âm Hoặc Bằng 0
    void BaiTap1()
    {
        Debug.Log("***** BaiTap1 *****");
        // Nhập một số từ bàn phím
        int number = Random.Range(-10, 10);
        // Kiểm tra xem số đó là số dương, âm hay bằng 0
        if (number == 0)
        {
            Debug.Log("So 0");
        }
        else if (number > 0)
        {
            Debug.Log("So duong");
        }
        else
        {
            Debug.Log("So am");
        }
    }

    // Bài Tập 2: Kiểm Tra Số Chẵn Hay Lẻ
    void BaiTap2()
    {
        Debug.Log("***** BaiTap2 *****");
        // Nhập một số từ bàn phím
        int number = Random.Range(-10, 10);
        // Kiểm tra xem số đó là số chẵn hay lẻ
        if (number % 2 == 0)
        {
            Debug.Log("So chan");
        }
        else
        {
            Debug.Log("So le");
        }
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Thi Đỗ
    void BaiTap3()
    {
        Debug.Log("***** BaiTap3 *****");
        // Nhập điểm trung bình của học sinh từ bàn phím
        float number = Random.Range(0, 10f);
        // Kiểm tra nếu điểm trung bình >= 5.0 thì học sinh đỗ, ngược lại thì trượt
        if (number >= 5.0f)
        {
            Debug.Log("Thi đỗ");
        }
        else
        {
            Debug.Log("Thi trược");
        }
    }

    // Bài Tập 4: Tìm Số Lớn Nhất Trong Hai Số
    void BaiTap4()
    {
        Debug.Log("***** BaiTap4 *****");
        // Nhập hai số nguyên từ bàn phím
        int a = Random.Range(-10, 10);
        int b = Random.Range(-10, 10);
        // Kiểm tra và in ra số lớn nhất trong hai số đó
        if (a > b)
        {
            Debug.Log(a);
        }
        else
        {
            Debug.Log(b);
        }
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap5()
    {
        Debug.Log("***** BaiTap5 *****");
        // Nhập số tiền hiện có và giá sản phẩm từ bàn phím
        int balance = Random.Range(0, 10);
        int cost = Random.Range(0, 10);
        // Kiểm tra xem người dùng có đủ tiền mua hàng không
        if (balance >= cost)
        {
            Debug.Log("Đủ tiền mua hàng");
        }
        else
        {
            Debug.Log("Không đủ tiền mua hàng");
        }
    }

    // Bài Tập 6: Kiểm Tra Năm Nhuận
    void BaiTap6()
    {
        Debug.Log("***** BaiTap6 *****");
        // Nhập một năm từ bàn phím
        int year = Random.Range(0, 99999);
        // Kiểm tra xem năm đó có phải là năm nhuận hay không
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Debug.Log("Là năm nhuận");
        }
        else
        {
            Debug.Log("Không là năm nhuận");
        }

    }

    // Bài Tập 7: Tính Giá Vé Xem Phim
    void BaiTap7()
    {
        Debug.Log("***** BaiTap7 *****");
        // Nhập tuổi của người mua vé từ bàn phím
        int age = Random.Range(0, 100);
        int cost = 50000;
        // Nếu người mua dưới 18 tuổi, giá vé là 50,000 đồng
        // Nếu người mua từ 18 tuổi trở lên, giá vé là 100,000 đồng
        if (age < 18)
        {
            cost = 50000;
            Debug.Log(cost);
        }
        else
        {
            cost = 100000;
            Debug.Log(cost);
        }
    }

    // Bài Tập 8: Kiểm Tra Học Sinh Xuất Sắc
    void BaiTap8()
    {
        Debug.Log("***** BaiTap8 *****");
        // Nhập điểm trung bình của học sinh từ bàn phím
        float score = Random.Range(-10f, 10f);
        // Kiểm tra xem học sinh có đạt danh hiệu xuất sắc không (điểm trung bình >= 9.0)
        if (score >= 9.0f)
        {
            Debug.Log("Học sinh đạt danh hiệu xuất sắc");
        }
        else
        {
            Debug.Log("Học sinh không đạt danh hiệu xuất sắc");
        }
    }

    // Bài Tập 9: So Sánh Ba Số
    void BaiTap9()
    {
        Debug.Log("***** BaiTap9 *****");
        // Nhập ba số nguyên từ bàn phím
        int num1 = Random.Range(-10, 10);
        int num2 = Random.Range(-10, 10);
        int num3 = Random.Range(-10, 10);
        // Kiểm tra và in ra số lớn nhất trong ba số đó
        if (num1 >= num2 && num1 >= num3)
        {
            Debug.Log(num1);
        }
        else if (num1 <= num2 && num2 >= num3)
        {
            Debug.Log(num2);
        }
        else if (num1 <= num3 && num2 <= num3)
        {
            Debug.Log(num3);
        }
    }

    // Bài Tập 10: Tính Tiền Lương
    void BaiTap10()
    {
        Debug.Log("***** BaiTap10 *****");
        // Nhập số giờ làm việc và mức lương cố định từ bàn phím
        int time = Random.Range(0, 80);
        int rate = Random.Range(500, 2000);
        // Nếu nhân viên làm trên 40 giờ, lương được tính thêm giờ
        // Nếu làm dưới hoặc bằng 40 giờ, lương tính theo giờ cố định
        if (time > 40)
        {
            Debug.Log("Lương + OT: " + ((time - 40) * (rate / 40) + rate) + "$");
        }
        else
        {
            Debug.Log("Lương: " + rate + "$");
        }
    }

    // Bài Tập 11: Kiểm Tra Điều Kiện Vào Câu Lạc Bộ
    void BaiTap11()
    {
        Debug.Log("***** BaiTap11 *****");
        // Nhập tuổi và kiểm tra xem người đó có thẻ thành viên hay không
        int age = Random.Range(0, 100);
        bool haveKey = Random.Range(0, 1) == 1 ? true : false;
        // Kiểm tra nếu trên 18 tuổi và có thẻ thành viên thì được vào câu lạc bộ
        if (age > 18 && haveKey)
        {
            Debug.Log("Được vào");
        }
        else
        {
            Debug.Log("Không được vào");
        }
    }

    // Bài Tập 12: Phân Loại Học Sinh
    void BaiTap12()
    {
        Debug.Log("***** BaiTap12 *****");
        // Nhập điểm trung bình của học sinh từ bàn phím
        float score = Random.Range(0, 10f);
        // Phân loại học sinh theo thang điểm từ xuất sắc đến yếu
        if (score > 9.0)
        {
            Debug.Log("Xuất sắc");
        }
        else if (score > 7.0)
        {
            Debug.Log("Khá");
        }
        else if (score > 5.0)
        {
            Debug.Log("Trung bình");
        }
        else
        {
            Debug.Log("Yếu");
        }
    }

    // Bài Tập 13: Tính Tiền Điện
    void BaiTap13()
    {
        Debug.Log("***** BaiTap13 *****");
        // Nhập số điện tiêu thụ từ bàn phím
        int score = Random.Range(0, 500);
        // Tính tiền điện theo công thức: <= 100 kWh: 1,500 đồng/kWh, >100 kWh: 2,000 đồng/kWh
        float total = 0;
        if (score <= 100)
        {
            total = score * 1500;
        }
        else
        {
            total = score * 2000;
        }
        Debug.Log(total);

    }

    // Bài Tập 14: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap14()
    {
        Debug.Log("***** BaiTap14 *****");
        // Nhập số năm làm việc và đánh giá công việc
        int age = Random.Range(0, 50);
        string evaluate = Random.Range(0, 1) == 1 ? "Tốt" : "Không tốt";
        // Kiểm tra nếu số năm làm việc trên 5 năm và đánh giá tốt thì đủ điều kiện thăng chức
        if (age > 5 && evaluate == "Tốt")
        {
            Debug.Log("Thăng chức");
        }
        else
        {

            Debug.Log("Không đủ điều kiện thăng chức");
        }
    }

    // Bài Tập 15: Kiểm Tra Điều Kiện Miễn Phí Vận Chuyển
    void BaiTap15()
    {
        Debug.Log("***** BaiTap15 *****");
        // Nhập giá trị đơn hàng từ bàn phím
        int price = Random.Range(0, 10000000);
        // Kiểm tra nếu giá trị đơn hàng >= 500,000 đồng thì được miễn phí vận chuyển
        if (price >= 500000)
        {
            Debug.Log("Miễn phí vận chuyển");
        }
    }

    // Bài Tập 16: Tính Thuế Thu Nhập Cá Nhân
    void BaiTap16()
    {
        Debug.Log("***** BaiTap16 *****");
        // Nhập thu nhập từ bàn phím
        int income = Random.Range(0, 100000000);
        // Tính thuế thu nhập cá nhân dựa trên mức thu nhập
        float tax = 0;

        // Mức thu nhập chịu thuế và các mức thuế suất theo luật Việt Nam (tham khảo)
        if (income <= 5000000)
        {
            tax = income * 0.05f; // 5% cho thu nhập <= 5 triệu
        }
        else if (income <= 10000000)
        {
            tax = 5000000 * 0.05f + (income - 5000000) * 0.1f; // 10% cho thu nhập > 5 triệu và <= 10 triệu
        }
        else if (income <= 18000000)
        {
            tax = 5000000 * 0.05f + 5000000 * 0.1f + (income - 10000000) * 0.15f; // 15% cho thu nhập > 10 triệu và <= 18 triệu
        }
        else if (income <= 32000000)
        {
            tax = 5000000 * 0.05f + 5000000 * 0.1f + 8000000 * 0.15f + (income - 18000000) * 0.2f; // 20% cho thu nhập > 18 triệu và <= 32 triệu
        }
        else if (income <= 52000000)
        {
            tax = 5000000 * 0.05f + 5000000 * 0.1f + 8000000 * 0.15f + 14000000 * 0.2f + (income - 32000000) * 0.25f; // 25% cho thu nhập > 32 triệu và <= 52 triệu
        }
        else if (income <= 80000000)
        {
            tax = 5000000 * 0.05f + 5000000 * 0.1f + 8000000 * 0.15f + 14000000 * 0.2f + 20000000 * 0.25f + (income - 52000000) * 0.3f; // 30% cho thu nhập > 52 triệu và <= 80 triệu
        }
        else
        {
            tax = 5000000 * 0.05f + 5000000 * 0.1f + 8000000 * 0.15f + 14000000 * 0.2f + 20000000 * 0.25f + 28000000 * 0.3f + (income - 80000000) * 0.35f; // 35% cho thu nhập > 80 triệu
        }

        Debug.Log("Thuế thu nhập cho " + income + " là " + tax);
    }

    // Bài Tập 17: Tính Điểm Trung Bình Của Môn Học
    void BaiTap17()
    {
        Debug.Log("***** BaiTap17 *****");
        // Nhập điểm của 3 bài kiểm tra từ bàn phím
        float num1 = Random.Range(0, 10f);
        float num2 = Random.Range(0, 10f);
        float num3 = Random.Range(0, 10f);
        // Tính điểm trung bình và kiểm tra xem học sinh có đạt yêu cầu hay không (>= 5.0)
        float score = (num1 + num2 + num3) / 3;

        if (score < 5.0)
        {
            Debug.Log("Không đạt yêu cầu");
        }
        else
        {
            Debug.Log("Đạt yêu cầu");
        }
    }

    // Bài Tập 18: Kiểm Tra Điều Kiện Nhập Hàng
    void BaiTap18()
    {
        Debug.Log("***** BaiTap18 *****");
        int item = Random.Range(0, 200);
        int slot = Random.Range(0, 10);
        // Nhập số lượng hàng hiện tại và kiểm tra khả năng nhập thêm hàng (dưới 100 và còn chỗ)
        if (item < 100 && slot != 0)
        {
            Debug.Log("Có thể nhập thêm hàng");
        }
        else
        {
            Debug.Log("Không thể nhập thêm hàng");
        }
    }

    // Bài Tập 19: Tìm Số Lớn Hơn 10
    void BaiTap19()
    {
        Debug.Log("***** BaiTap19 *****");
        // Nhập một số từ bàn phím
        int num = Random.Range(0, 200);
        // Kiểm tra xem số đó có lớn hơn 10 hay không
        if(num >10)
        {
            Debug.Log("Lớn hơn 10");
        }
        else
        {
            Debug.Log("Không lớn hơn 10");
        }
    }

    // Bài Tập 20: Kiểm Tra Điều Kiện Đăng Ký Khóa Học
    void BaiTap20()
    {
        Debug.Log("***** BaiTap20 *****");
        // Nhập điểm tổng kết và các điều kiện khác từ bàn phím
        float score = Random.Range(0, 10f);
        bool complete = Random.Range(0, 1) == 1 ? true : false;
        bool haveCast = Random.Range(0, 1) == 1 ? true : false;
        // Kiểm tra xem học sinh có đủ điều kiện đăng ký khóa học nâng cao không
        if (score > 7.0f && complete && haveCast)
        {
            Debug.Log("Đủ điều kiện đăng ký khóa học nâng cao");
        }
        else
        {
            Debug.Log("Không đủ điều kiện đăng ký khóa học nâng cao");
        }
    }
}
