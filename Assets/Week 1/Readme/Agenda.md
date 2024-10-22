# Agenda Phát Triển Game Week 1

## 1. Tìm Giá Trị Lớn Nhất Mà Int, Float và Double Trong Unity C# Có Thể Lưu Trữ
int: 2147483647
float: 3.402823E+38
double: 1.79769313486232E+308

## 2. Nhờ AI Thiết Kế Ra Một Kế Hoạch Làm Game Trong 1 Tháng
https://docs.google.com/document/d/1wCMNN_eQOHKDEjaPfha119-sqfmAIplbvaMSc9SAGUY/edit?usp=sharing

## 3. Khai Báo Thêm 5 Methods Cho Class Enemy

## 4. Khai Báo Thêm 5 Biến Cho Class Enemy

## 5. Nhờ AI Giải Thích Câu Lệnh Này: `int[] scores = new int[10];`
Câu lệnh int[] scores = new int[10]; trong C# (và Unity C#) thực hiện việc khai báo và khởi tạo một mảng (array) với các phần tử có kiểu dữ liệu là int. Cụ thể:

int[]: Đây là khai báo một mảng có các phần tử kiểu int. Dấu [] chỉ ra rằng scores sẽ là một mảng (array).
scores: Đây là tên của biến mảng mà bạn đặt, trong trường hợp này là scores.
new int[10]: Từ khóa new được sử dụng để khởi tạo mảng với số phần tử xác định. int[10] chỉ ra rằng mảng này sẽ chứa 10 phần tử có kiểu dữ liệu là int. Mỗi phần tử trong mảng này ban đầu sẽ được gán giá trị mặc định của kiểu int, tức là 0.
Sau khi thực hiện dòng lệnh này, mảng scores sẽ có 10 phần tử với các giá trị ban đầu là 0. Bạn có thể truy cập và gán giá trị cho từng phần tử trong mảng bằng chỉ số (index)

## 6. Nhờ AI Giải Thích Về Rigidbody
Trong Unity, Rigidbody là một thành phần (component) dùng để mô phỏng vật lý thực tế cho đối tượng 3D trong game. Khi bạn thêm Rigidbody vào một đối tượng, Unity sẽ tính toán và xử lý các hiệu ứng vật lý như trọng lực, va chạm và lực tác động lên đối tượng đó.

Chức năng chính của Rigidbody:
Trọng lực: Khi Rigidbody được gắn vào một đối tượng, đối tượng đó sẽ bị ảnh hưởng bởi trọng lực, tức là nó sẽ rơi xuống nếu không có lực nào giữ nó lại.
Va chạm (Collisions): Khi đối tượng có Rigidbody tương tác với các vật thể khác có collider, Unity sẽ xử lý va chạm giữa chúng. Các đối tượng có collider nhưng không có Rigidbody sẽ không thể bị di chuyển bởi lực.
Lực (Forces): Bạn có thể tác động lực lên đối tượng bằng cách sử dụng các phương thức như AddForce, AddTorque, để làm cho đối tượng di chuyển, quay, hoặc bị đẩy theo hướng lực.
Mô phỏng vật lý: Unity sẽ tự động tính toán mô phỏng các hiện tượng vật lý như ma sát, khối lượng, và động lượng của các đối tượng.
Các thuộc tính quan trọng của Rigidbody:
Mass: Khối lượng của đối tượng (được đo bằng kilôgam), ảnh hưởng đến cách đối tượng phản ứng với các lực tác động lên nó.
Drag: Lực cản tác động lên đối tượng, làm giảm tốc độ của nó khi di chuyển.
Angular Drag: Lực cản góc, làm giảm tốc độ quay của đối tượng.
Use Gravity: Nếu được bật, đối tượng sẽ chịu ảnh hưởng của trọng lực.
Is Kinematic: Khi bật tùy chọn này, đối tượng sẽ không bị ảnh hưởng bởi lực hoặc trọng lực, nhưng vẫn có thể được điều khiển bằng cách thủ công (code).

## 7. Hỏi AI Cách Chia Lấy Dư Một Số Bất Kỳ
Trong C# (và Unity C#), bạn có thể chia lấy dư của một số bất kỳ bằng cách sử dụng toán tử % (modulus). Toán tử này trả về phần dư khi chia hai số với nhau.

## 8. Ngoài Các Kiểu Dữ Liệu Đã Giới Thiệu, Kể Tên 5 Kiểu Dữ Liệu Khác Của Unity C#
byte
char
long
decimal
bool

## 9. Ngoài Các Toán Tử Đã Giới Thiệu, Hãy Kể Tên 3 Toán Tử Khác
&&
||
!=
