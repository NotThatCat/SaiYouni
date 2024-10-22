# 5 Loại Giải Thuật Sắp Xếp Khác Nhau

## Giới Thiệu

Sắp xếp là một trong những thao tác cơ bản và quan trọng trong lập trình và khoa học máy tính. Có nhiều giải thuật sắp xếp khác nhau, mỗi giải thuật có ưu và nhược điểm riêng, phù hợp với các tình huống khác nhau.

## 1. Trả lời 1
Bubble Sort
Thuật toán Bubble Sort là một trong những thuật toán sắp xếp đơn giản nhất. Thuật toán này hoạt động dựa trên ý tưởng so sánh cặp phần tử liên tiếp và hoán đổi chúng nếu chúng không theo đúng thứ tự. Quá trình này được lặp đi lặp lại cho đến khi toàn bộ danh sách đã được sắp xếp.

Các bước thực hiện thuật toán:
 - Bắt đầu từ phần tử đầu tiên, so sánh nó với phần tử kế tiếp.
 - Nếu phần tử hiện tại lớn hơn phần tử kế tiếp, hoán đổi chúng.
 - Di chuyển sang cặp phần tử kế tiếp (phần tử thứ hai và thứ ba), lặp lại quá trình so sánh và hoán đổi.
 - Lặp lại quá trình cho toàn bộ danh sách. Sau mỗi vòng lặp, phần tử lớn nhất trong danh sách sẽ "nổi" lên vị trí cuối cùng, giống như bong bóng nổi lên trên, do đó tên của thuật toán là "Bubble Sort".
 - Tiếp tục lặp lại cho các phần tử còn lại (trừ phần tử đã được đặt đúng vị trí ở cuối danh sách).
 - Quá trình kết thúc khi không còn sự hoán đổi nào diễn ra trong một vòng lặp.

Độ phức tạp:
Độ phức tạp thời gian: O(n²), với n là số phần tử trong danh sách.
Độ phức tạp không gian: O(1), vì chỉ cần sử dụng một vài biến phụ.

## 2. Trả lời 2
Insertion Sort
Thuật toán Insertion Sort là một thuật toán sắp xếp tương đối đơn giản và dễ hiểu, tương tự như cách chúng ta sắp xếp một bộ bài theo thứ tự. Thuật toán này hoạt động bằng cách chia danh sách thành hai phần: một phần đã được sắp xếp và một phần chưa sắp xếp. Sau đó, nó sẽ chèn từng phần tử từ phần chưa sắp xếp vào đúng vị trí trong phần đã sắp xếp.

Các bước thực hiện:
 - Giả sử phần tử đầu tiên là đã sắp xếp.
 - Bắt đầu từ phần tử thứ hai, duyệt qua danh sách:
    Chọn phần tử hiện tại từ danh sách chưa sắp xếp.
    So sánh phần tử này với các phần tử trong danh sách đã sắp xếp từ phải sang trái.
    Chèn phần tử hiện tại vào đúng vị trí sao cho phần đã sắp xếp vẫn theo thứ tự.
 - Lặp lại bước 2 cho đến khi toàn bộ danh sách được sắp xếp.

Độ phức tạp:
Độ phức tạp thời gian:
Trường hợp tốt nhất: O(n) (khi danh sách đã được sắp xếp).
Trường hợp trung bình và xấu nhất: O(n²) (khi danh sách ngẫu nhiên hoặc sắp xếp ngược lại).
Độ phức tạp không gian: O(1) vì thuật toán này thực hiện tại chỗ, không cần sử dụng bộ nhớ bổ sung.

## 3. Trả lời 3
Selection Sort
Thuật toán Selection Sort là một trong những thuật toán sắp xếp đơn giản, hoạt động dựa trên việc tìm phần tử nhỏ nhất (hoặc lớn nhất) trong danh sách chưa được sắp xếp và hoán đổi nó với phần tử ở đầu danh sách. Quá trình này được lặp lại cho đến khi toàn bộ danh sách được sắp xếp.

Cách hoạt động:
 - Chia danh sách thành hai phần: phần đã được sắp xếp và phần chưa sắp xếp.
 - Bắt đầu từ đầu danh sách, tìm phần tử nhỏ nhất trong phần chưa sắp xếp.
 - Sau khi tìm được phần tử nhỏ nhất, hoán đổi nó với phần tử đầu tiên của phần chưa sắp xếp.
 - Di chuyển ranh giới giữa phần sắp xếp và chưa sắp xếp sang bên phải.
 - Lặp lại quá trình cho đến khi toàn bộ danh sách được sắp xếp.

Độ phức tạp:
Độ phức tạp thời gian: Trường hợp tốt nhất, trung bình và xấu nhất: O(n²), vì luôn phải tìm phần tử nhỏ nhất trong mỗi vòng lặp dù danh sách có sắp xếp hay không.
Độ phức tạp không gian: O(1), vì thuật toán thực hiện sắp xếp tại chỗ mà không cần dùng bộ nhớ bổ sung.


## 4. Trả lời 4
Thuật toán Merge Sort là một thuật toán sắp xếp chia để trị (Divide and Conquer), được coi là một trong những thuật toán sắp xếp hiệu quả với độ phức tạp O(n log n). Merge Sort hoạt động bằng cách chia danh sách thành các phần nhỏ hơn, sắp xếp các phần này, và sau đó gộp chúng lại để tạo thành một danh sách đã sắp xếp hoàn chỉnh.

Nguyên lý hoạt động:
Thuật toán này bao gồm hai bước chính:

1. Chia (Divide): Chia danh sách ban đầu thành hai nửa cho đến khi mỗi nửa chỉ còn một phần tử (vì danh sách chỉ có một phần tử thì coi như đã sắp xếp).
2. Gộp (Conquer): Sau khi các danh sách nhỏ đã được sắp xếp, bắt đầu gộp (merge) chúng lại với nhau theo thứ tự tăng dần để tạo ra một danh sách lớn hơn.
Các bước chi tiết:
 - Nếu danh sách chỉ có một phần tử hoặc rỗng, coi như đã sắp xếp và trả về ngay.
 - Chia danh sách thành hai nửa (lấy chỉ số giữa để tách).
 - Gọi đệ quy để tiếp tục sắp xếp từng nửa.
 - Sau khi hai nửa đã được sắp xếp, gộp chúng lại thành một danh sách duy nhất theo thứ tự tăng dần.

Độ phức tạp:
Thời gian: Merge Sort có độ phức tạp thời gian là O(n log n) trong tất cả các trường hợp (tốt nhất, trung bình, xấu nhất).
Lý do là vì danh sách được chia làm đôi ở mỗi bước, mất log(n) bước để chia hết danh sách. Sau đó, việc gộp các danh sách mất O(n) trong mỗi bước gộp.
Không gian: Merge Sort yêu cầu thêm không gian O(n) để lưu trữ các danh sách con trong quá trình chia và gộp.

## 5. Trả lời 5
Quick Sort là một thuật toán sắp xếp dựa trên phương pháp chia để trị (Divide and Conquer). Giống như Merge Sort, Quick Sort chia danh sách thành các phần nhỏ để sắp xếp. Tuy nhiên, điểm khác biệt là Quick Sort không cần sử dụng thêm bộ nhớ như Merge Sort, và thường được coi là một trong những thuật toán sắp xếp nhanh và hiệu quả nhất trong thực tế.

Nguyên lý hoạt động:
1. Chọn pivot (điểm chốt): Chọn một phần tử từ danh sách làm pivot. Đây là yếu tố quyết định cách chia danh sách.
2. Phân chia (Partition): Đưa tất cả các phần tử nhỏ hơn pivot sang một bên và các phần tử lớn hơn pivot sang bên kia. Sau khi quá trình này hoàn tất, pivot đã được đặt ở đúng vị trí trong danh sách sắp xếp.
3. Đệ quy (Recursive): Áp dụng Quick Sort đệ quy cho hai danh sách con (phần trước pivot và phần sau pivot) cho đến khi danh sách chỉ còn một phần tử hoặc không còn phần tử nào (khi đó danh sách đã được sắp xếp).
Các bước chi tiết:
 - Nếu danh sách chỉ có 0 hoặc 1 phần tử, coi như đã sắp xếp và trả về ngay.
 - Chọn một phần tử pivot (có thể chọn ngẫu nhiên, chọn phần tử đầu, giữa, hoặc cuối danh sách).
 - Chia danh sách thành hai phần:
    Phần trái chứa các phần tử nhỏ hơn hoặc bằng pivot.
    Phần phải chứa các phần tử lớn hơn pivot.
 - Áp dụng Quick Sort đệ quy cho phần trái và phần phải.
 - Kết hợp các phần đã sắp xếp: Phần trái + pivot + phần phải.

Độ phức tạp:
Độ phức tạp thời gian:
 - Trường hợp trung bình và tốt nhất: O(n log n). Trong trường hợp này, pivot chia danh sách thành hai phần cân đối.
 - Trường hợp xấu nhất: O(n²). Trường hợp xấu nhất xảy ra khi pivot chọn không tốt (ví dụ như khi chọn pivot là phần tử lớn nhất hoặc nhỏ nhất trong danh sách đã sắp xếp ngược).
Độ phức tạp không gian: O(log n), vì thuật toán sử dụng đệ quy và bộ nhớ phụ thuộc vào chiều sâu của đệ quy.


# Thuật toán thêm khác với thuật toán đã học

## Trả lời
Quick Sort, Insertion Sort, Bubble Sort, Merge Sort, Heap Sort,...
