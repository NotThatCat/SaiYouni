using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Reflection;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class ANDPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra tuổi, giấy phép, và kinh nghiệm
        BaiTap2(); // Kiểm tra điều kiện vào công viên giải trí
        BaiTap3(); // Điều kiện đạt học bổng
        BaiTap4(); // Kiểm tra đăng ký hợp lệ
        BaiTap5(); // Kiểm tra điều kiện thi lại
        BaiTap6(); // Xét tuyển nhân viên
        BaiTap7(); // Kiểm tra điều kiện mua hàng
        BaiTap8(); // Đủ điều kiện nhận phần thưởng
        BaiTap9(); // Kiểm tra điều kiện thăng chức
        BaiTap10(); // Điều kiện nhận vé miễn phí
    }

    // Bài Tập 1: Kiểm Tra Tuổi, Giấy Phép, Và Kinh Nghiệm
    void BaiTap1()
    {
        // Nhập tuổi, giấy phép lái xe, và kinh nghiệm lái xe
        var age = Random.Range(0, 50);
        var license = Random.Range(0, 2) == 0 ? true : false;
        var exp = Random.Range(0, 20);

        // Kiểm tra nếu người dùng trên 18 tuổi, có giấy phép lái xe, và có kinh nghiệm trên 1 năm
        if (age > 18 && license && exp > 1)
        {
            Debug.Log("Thỏa điều kiện");
        }
        else
        {
            Debug.Log("Không thỏa điều kiện");
        }
    }

    // Bài Tập 2: Kiểm Tra Điều Kiện Vào Công Viên Giải Trí
    void BaiTap2()
    {
        // Nhập thông tin về vé, đã đăng ký trước, và tiền sử bệnh tim
        var ticket = Random.Range(0, 2) == 0 ? true : false;
        var regis = Random.Range(0, 2) == 0 ? true : false;
        var tim = Random.Range(0, 2) == 0 ? true : false;

        // Kiểm tra nếu người dùng có vé, đã đăng ký trước, và không có tiền sử bệnh tim
        if (ticket && regis && !tim)
        {
            Debug.Log("Thỏa điều kiện");
        }
        else
        {
            Debug.Log("Không thỏa điều kiện");
        }
    }

    // Bài Tập 3: Điều Kiện Đạt Học Bổng
    void BaiTap3()
    {
        // Nhập điểm trung bình, điểm hoạt động ngoại khóa, và kiểm tra kỷ luật
        var score1 = Random.Range(0f, 10f);
        var score2 = Random.Range(0f, 10f);
        var discipline = Random.Range(0, 2) == 0 ? true : false;

        // Kiểm tra nếu điểm trung bình >= 9.0, điểm ngoại khóa >= 8.0, và không vi phạm kỷ luật
        if (score1 >= 9.0 && score2 >= 8.0 && !discipline)
        {
            Debug.Log("Thỏa điều kiện");
        }
        else
        {
            Debug.Log("Không thỏa điều kiện");
        }
    }

    protected virtual bool ValidateMail()
    {
        return Random.Range(0, 2) == 0 ? true : false;
    }

    // Bài Tập 4: Kiểm Tra Đăng Ký Hợp Lệ
    void BaiTap4()
    {
        // Nhập thông tin email, xác nhận qua điện thoại, và phí tham gia
        var mail = Random.Range(0f, 10f);
        var phoneValidate = Random.Range(0, 2) == 0 ? true : false;
        var ticket = Random.Range(0, 2) == 0 ? true : false;

        // Kiểm tra nếu email hợp lệ, đã xác nhận qua điện thoại, và đã thanh toán phí tham gia
        if (ValidateMail() && phoneValidate && ticket)
        {
            Debug.Log("Đăng kí hợp lệ");
        }
        else
        {
            Debug.Log("Đăng kí không hợp lệ");
        }
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Thi Lại
    void BaiTap5()
    {
        // Nhập điểm tổng kết, số môn thi trượt, và điểm chuyên cần
        var score1 = Random.Range(0f, 10f);
        var failCount = Random.Range(0, 10);
        var score3 = Random.Range(0f, 1f);

        // Kiểm tra nếu điểm tổng kết < 5.0, số môn trượt <= 2, và điểm chuyên cần > 75%
        if (score1 < 5.0 && failCount <= 2 && score3 > 0.75)
        {
            Debug.Log("Thỏa Điều Kiện Thi Lại");
        }
        else
        {
            Debug.Log("Không thỏa Điều Kiện Thi Lại");
        }
    }

    // Bài Tập 6: Xét Tuyển Nhân Viên
    void BaiTap6()
    {
        // Nhập thông tin về bằng đại học, kinh nghiệm và bài kiểm tra năng lực
        var degree = Random.Range(0, 2) == 0 ? true : false;
        var exp = Random.Range(0, 10);
        var testResult = Random.Range(0, 2) == 0 ? true : false;

        // Kiểm tra nếu ứng viên đã tốt nghiệp đại học, có ít nhất 2 năm kinh nghiệm, và vượt qua bài kiểm tra năng lực
        if (degree && exp >= 2 && testResult)
        {
            Debug.Log("Thỏa Điều Kiện Xét Tuyển Nhân Viên");
        }
        else
        {
            Debug.Log("Không thỏa Điều Kiện Xét Tuyển Nhân Viên");
        }
    }

    // Bài Tập 7: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap7()
    {
        // Nhập số tiền hiện có, kiểm tra hàng trong kho và chương trình khuyến mãi
        var cash = Random.Range(0, 2) == 0 ? true : false;
        var store = Random.Range(0, 2) == 0 ? true : false;
        var sale = Random.Range(0, 2) == 0 ? true : false;

        // Kiểm tra nếu người dùng có đủ tiền, có hàng trong kho, và đủ điều kiện tham gia khuyến mãi
        if (cash && store && sale)
        {
            Debug.Log("Thỏa Điều Kiện Mua Hàng");
        }
        else
        {
            Debug.Log("Không thỏa Điều Kiện Mua Hàng");
        }
    }

    // Bài Tập 8: Đủ Điều Kiện Nhận Phần Thưởng
    void BaiTap8()
    {
        // Nhập thông tin về nhiệm vụ hoàn thành, điểm trung bình nhiệm vụ, và đăng nhập hệ thống
        var mission = Random.Range(0, 20);
        var score = Random.Range(0, 10);
        var loginLast7days = Random.Range(0, 2) == 0 ? true : false;

        // Kiểm tra nếu đã hoàn thành ít nhất 10 nhiệm vụ, điểm nhiệm vụ >= 8, và đăng nhập vào hệ thống trong 7 ngày qua
        if (mission >= 10 && score >= 8 && loginLast7days)
        {
            Debug.Log("Thỏa Điều Kiện Nhận Phần Thưởng");
        }
        else
        {
            Debug.Log("Không thỏa Điều Kiện Nhận Phần Thưởng");
        }
    }

    // Bài Tập 9: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap9()
    {
        // Nhập số năm làm việc, chỉ tiêu công việc và vi phạm kỷ luật
        var workAge = Random.Range(0f, 20f);
        var result = Random.Range(0, 2) == 0 ? true : false;
        var kyluat = Random.Range(0, 2) == 0 ? true : false;
        // Kiểm tra nếu đã làm việc trên 5 năm, đạt chỉ tiêu công việc và không vi phạm kỷ luật
        if (workAge > 5 && result && kyluat)
        {
            Debug.Log("Thỏa Điều Kiện Nhận Thăng Chức");
        }
        else
        {
            Debug.Log("Không thỏa Điều Kiện Nhận Thăng Chức");
        }

    }

    // Bài Tập 10: Điều Kiện Nhận Vé Miễn Phí
    void BaiTap10()
    {
        // Nhập tuổi, trạng thái thành viên VIP, và số lần mua vé trong năm
        var age = Random.Range(0, 100);
        var vip = Random.Range(0, 2) == 0 ? true : false;
        var ticket = Random.Range(0, 10);

        // Kiểm tra nếu người dùng trên 60 tuổi, là thành viên VIP, và đã mua vé ít nhất 3 lần trong năm
        if (age > 60 && vip && ticket >= 3)
        {
            Debug.Log("Thỏa Điều Kiện Nhận Nhận Vé Miễn Phí");
        }
        else
        {
            Debug.Log("Không thỏa Điều Kiện Nhận Vé Miễn Phí");
        }
    }
}
