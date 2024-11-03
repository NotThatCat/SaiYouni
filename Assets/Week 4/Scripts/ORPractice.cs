using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.tvOS;

public class ORPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra vé vào cửa
        BaiTap2(); // Điều kiện trúng thưởng
        BaiTap3(); // Kiểm tra điều kiện vay tiền
        BaiTap4(); // Điều kiện nhận học bổng
        BaiTap5(); // Kiểm tra đăng ký sự kiện
        BaiTap6(); // Điều kiện lái xe
        BaiTap7(); // Kiểm tra quyền truy cập tài liệu
        BaiTap8(); // Kiểm tra điều kiện tham gia khóa học
        BaiTap9(); // Điều kiện tải ứng dụng miễn phí
        BaiTap10(); // Điều kiện sử dụng dịch vụ đặc biệt
    }

    // Bài Tập 1: Kiểm Tra Vé Vào Cửa
    void BaiTap1()
    {
        var ticket = Random.Range(0, 2) == 0 ? true : false;
        var vip = Random.Range(0, 2) == 0 ? true : false;
        var invite = Random.Range(0, 2) == 0 ? true : false;
        // Kiểm tra xem người dùng có thể vào sự kiện nếu có vé hợp lệ, là thành viên VIP, hoặc được mời
        if (ticket || vip || invite)
        {
            Debug.Log("Có thể vào sự kiện");
        }
        else
        {
            Debug.Log("Không thể vào sự kiện");
        }
    }

    // Bài Tập 2: Điều Kiện Trúng Thưởng
    void BaiTap2()
    {
        var ticket = Random.Range(0, 10);
        // Kiểm tra xem người dùng có trúng thưởng nếu số vé của họ trúng giải nhất, nhì, hoặc ba
        if (ticket == 0 || ticket == 1 || ticket == 2)
        {
            Debug.Log("Có Trúng Thưởng");
        }
        else
        {
            Debug.Log("Không Trúng Thưởng");
        }
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Vay Tiền
    void BaiTap3()
    {
        var income = Random.Range(0, 2) == 0 ? true : false;
        var mortgage = Random.Range(0, 2) == 0 ? true : false;
        var guarantee = Random.Range(0, 2) == 0 ? true : false;
        // Kiểm tra xem người dùng có đủ điều kiện vay tiền nếu có thu nhập ổn định, tài sản thế chấp, hoặc người bảo lãnh
        if (income || mortgage || guarantee)
        {
            Debug.Log("Có thể vay tiền");
        }
        else
        {
            Debug.Log("Không thể vay tiền");
        }
    }

    // Bài Tập 4: Điều Kiện Nhận Học Bổng
    void BaiTap4()
    {
        var grade = Random.Range(0, 5);
        var isGoodActivity = Random.Range(0, 2) == 0 ? true : false;
        var familyType = Random.Range(0, 2) == 0 ? true : false;
        // Kiểm tra xem học sinh có nhận được học bổng nếu có thành tích học tập xuất sắc, hoạt động ngoại khóa tốt, hoặc gia đình khó khăn
        if (grade == 0 || isGoodActivity || familyType)
        {
            Debug.Log("Đủ Điều Kiện Nhận Học Bổng");
        }
        else
        {
            Debug.Log("Không đủ Điều Kiện Nhận Học Bổng");
        }
    }

    // Bài Tập 5: Kiểm Tra Đăng Ký Sự Kiện
    void BaiTap5()
    {
        var validMail = Random.Range(0, 2) == 0 ? true : false;
        var validPhone = Random.Range(0, 2) == 0 ? true : false;
        var registed = Random.Range(0, 2) == 0 ? true : false;
        // Kiểm tra xem người dùng có thể đăng ký sự kiện nếu có email hợp lệ, số điện thoại xác thực, hoặc đã đăng ký qua trang web
        if (validMail || validPhone || registed)
        {
            Debug.Log("Có thể Đăng Ký Sự Kiện");
        }
        else
        {
            Debug.Log("Không có thể Đăng Ký Sự Kiện");
        }
    }

    // Bài Tập 6: Điều Kiện Lái Xe
    void BaiTap6()
    {
        var driveLicence = Random.Range(0, 2) == 0 ? true : false;
        var carLicence = Random.Range(0, 2) == 0 ? true : false;
        var carInsurance = Random.Range(0, 2) == 0 ? true : false;
        // Kiểm tra xem người dùng có thể lái xe nếu có bằng lái, đã đăng ký xe hợp lệ, hoặc có bảo hiểm xe
        if (driveLicence || carLicence || carInsurance)
        {
            Debug.Log("Đủ Điều Kiện Lái Xe");
        }
        else
        {
            Debug.Log("Không Đủ Điều Kiện Lái Xe");
        }
    }

    // Bài Tập 7: Kiểm Tra Quyền Truy Cập Tài Liệu
    void BaiTap7()
    {
        var isAdmin = Random.Range(0, 2) == 0 ? true : false;
        var accessPermission = Random.Range(0, 2) == 0 ? true : false;
        var validCode = Random.Range(0, 2) == 0 ? true : false;
        // Kiểm tra xem người dùng có quyền truy cập tài liệu nếu là quản trị viên, được cấp quyền truy cập từ quản lý, hoặc có mã xác thực
        if (isAdmin || accessPermission || validCode)
        {
            Debug.Log("Đủ Quyền Truy Cập Tài Liệu");
        }
        else
        {
            Debug.Log("Không Đủ Quyền Truy Cập Tài Liệu");
        }
    }

    // Bài Tập 8: Kiểm Tra Điều Kiện Tham Gia Khóa Học
    void BaiTap8()
    {
        var promote = Random.Range(0, 2) == 0 ? true : false;
        var testSuccess = Random.Range(0, 2) == 0 ? true : false;
        var exp = Random.Range(0, 2) == 0 ? true : false;
        // Kiểm tra xem học sinh có thể tham gia khóa học đặc biệt nếu có thư giới thiệu từ giáo viên, đã hoàn thành bài kiểm tra đầu vào, hoặc có kinh nghiệm liên quan
        if (promote || testSuccess || exp)
        {
            Debug.Log("Đủ Điều Kiện Tham Gia Khóa Học");
        }
        else
        {
            Debug.Log("Không Đủ Điều Kiện Tham Gia Khóa Học");
        }
    }

    // Bài Tập 9: Điều Kiện Tải Ứng Dụng Miễn Phí
    void BaiTap9()
    {
        var code = Random.Range(0, 2) == 0 ? true : false;
        var vip = Random.Range(0, 2) == 0 ? true : false;
        var freeTrial = Random.Range(0, 2) == 0 ? true : false;
        // Kiểm tra xem người dùng có thể tải ứng dụng miễn phí nếu có mã khuyến mãi, là thành viên VIP, hoặc ứng dụng đang trong thời gian miễn phí
        if (code || vip || freeTrial)
        {
            Debug.Log("Đủ Điều Kiện Tải Ứng Dụng Miễn Phí");
        }
        else
        {
            Debug.Log("Không Đủ Điều Kiện Tải Ứng Dụng Miễn Phí");
        }
    }

    // Bài Tập 10: Điều Kiện Sử Dụng Dịch Vụ Đặc Biệt
    void BaiTap10()
    {
        var purchaseRate = Random.Range(0, 2) == 0 ? true : false;
        var loyalCustomer = Random.Range(0, 2) == 0 ? true : false;
        var freeTrial = Random.Range(0, 2) == 0 ? true : false;
        // Kiểm tra xem khách hàng có thể sử dụng dịch vụ đặc biệt nếu đã chi tiêu trên mức yêu cầu, là khách hàng thân thiết, hoặc có chương trình khuyến mãi
        if (purchaseRate || loyalCustomer || freeTrial)
        {
            Debug.Log("Đủ Điều Kiện Sử Dụng Dịch Vụ Đặc Biệt");
        }
        else
        {
            Debug.Log("Không Đủ Điều Kiện Sử Dụng Dịch Vụ Đặc Biệt");
        }
    }
}
